using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Contexts;

namespace WindowsFormsApp
{
    public enum EditFormMode
    {
        Insert,
        Update
    }
    public partial class ClietnEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EditFormMode mode = EditFormMode.Insert;
        int _clientId = -1;
        public ClietnEditForm(int clientId = -1)
        {
            InitializeComponent();
            _clientId = clientId;
            if(_clientId > 0)
            {
                using (var context = new AppDbContext())
                {
                    var client = context.Clients.Where(x=>x.Id == _clientId).SingleOrDefault();
                    teName.Text = client.Name;
                    teContactInfo.Text = client.ContactInfo;
                }
            }
        }

        private void btnIndert_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnApplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (mode)
            {
                case EditFormMode.Insert:
                    using (var context = new AppDbContext())
                    {
                        var addClient = context.Clients.Add(new Entitys.Client
                        {
                            Name = teName.Text,
                            ContactInfo = teContactInfo.Text
                        });
                        addClient.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                        context.SaveChanges(); 
                    }

                    break;
                case EditFormMode.Update:
                    using (var context = new AppDbContext())
                    {
                        var addUpdate = context.Clients.Add(new Entitys.Client
                        {
                            Id = _clientId,
                            Name = teName.Text,
                            ContactInfo = teContactInfo.Text
                        });
                        addUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }

                    break;
            }

          


            this.Close();
        }
    }
}