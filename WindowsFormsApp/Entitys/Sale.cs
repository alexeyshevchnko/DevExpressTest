using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Entitys
{
    public class Sale
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.UtcNow;

        public Client Client { get; set; }
        public List<SaleItems> SaleItems { get; set; }
    }
}
