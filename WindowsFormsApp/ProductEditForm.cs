using DevExpress.XtraBars;
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
    public partial class ProductEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _productId = -1;
        public EditFormMode mode = EditFormMode.Insert;

        public ProductEditForm(int id = -1)
        {
            _productId = id;
            InitializeComponent();
            if (_productId > 0)
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.Where(x => x.Id == _productId).SingleOrDefault();
                    teName.Text = product.Name;
                    tePrice.Text = product.Price.ToString();
                }
            }
        }

        private void btnApplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (mode)
            {
                case EditFormMode.Insert:
                    using (var context = new AppDbContext())
                    {
                        var addProduct = context.Products.Add(new Entitys.Product
                        {
                            Name = teName.Text,
                            Price = decimal.Parse(tePrice.Text)
                        });
                        addProduct.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                        context.SaveChanges();
                    }

                    break;
                case EditFormMode.Update:
                    using (var context = new AppDbContext())
                    {
                        var updateProduct = context.Products.Add(new Entitys.Product
                        {
                            Id = _productId,
                            Name = teName.Text,
                            Price = decimal.Parse(tePrice.Text)
                        });
                        updateProduct.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }

                    break;
            }




            this.Close();
        }
    }
}