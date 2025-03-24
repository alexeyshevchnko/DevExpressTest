using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Entitys
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public decimal TotalSales { get; set; } // Будет обновляться через триггер
    }
}
