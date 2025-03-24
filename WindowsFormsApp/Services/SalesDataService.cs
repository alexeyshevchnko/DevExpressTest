using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Contexts;

namespace WindowsFormsApp.Services
{
    public class SalesDataService
    {
        private readonly AppDbContext _context;

        public SalesDataService(AppDbContext context)
        {
            _context = context;
        }

        public List<SalesData> GetSalesDataByDate(DateTime startDate, DateTime endDate)
        {
            var filteredSalesData = from sale in _context.Sales
                                    join client in _context.Clients on sale.ClientId equals client.Id
                                    join saleItem in _context.SaleItems on sale.Id equals saleItem.SaleId
                                    join product in _context.Products on saleItem.ProductId equals product.Id
                                    where sale.SaleDate >= startDate && sale.SaleDate <= endDate
                                    select new SalesData
                                    {
                                        ClientName = client.Name,
                                        ProductName = product.Name,
                                        TotalPrice = saleItem.TotalPrice,
                                        SaleDate = sale.SaleDate
                                    };

            return filteredSalesData.ToList();
        }

        public List<ClientSalesReport> GetClientSalesReport(int clientId, DateTime startDate, DateTime endDate)
        {
            var reportData = from sale in _context.Sales
                             join client in _context.Clients on sale.ClientId equals client.Id
                             join saleItem in _context.SaleItems on sale.Id equals saleItem.SaleId
                             join product in _context.Products on saleItem.ProductId equals product.Id
                             where sale.ClientId == clientId && sale.SaleDate >= startDate && sale.SaleDate <= endDate
                             group saleItem by new { sale.SaleDate.Year, sale.SaleDate.Month, product.Name } into g
                             select new ClientSalesReport
                             {
                                 ProductName = g.Key.Name,
                                 Year = g.Key.Year,
                                 Month = g.Key.Month,
                                 TotalSales = g.Sum(x => x.TotalPrice)
                             };

            return reportData.ToList();
        }
    }

    public class SalesData
    {
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }

    public class ClientSalesReport
    {
        public string ProductName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName
        {
            get
            {
                var months = new[]
                {
                "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };

                return months[Month - 1];  
            }
        }

        public decimal TotalSales { get; set; }
    }
}
