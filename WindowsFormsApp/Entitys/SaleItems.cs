using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Entitys
{
    public class SaleItems
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; } // Автоматически обновляется триггером в БД

        public Sale Sale { get; set; }
        public Product Product { get; set; }
    }
}
