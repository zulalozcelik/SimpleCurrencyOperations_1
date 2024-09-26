using ConsoleDersleri_4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDersleri_4.Classes
{
    public class SaleOperation
    {
        public void CustomerSaleOperationAlis()
        {
            ConsoleDbProjeEntities1 db = new ConsoleDbProjeEntities1();
            var values = db.TblOperation.Where(x=>x.OperationType=="alış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID:" + item.ID + "müşteri:" + item.CustomerName + " " + item.CustomerSurname + "Döviz: " + item.TblCurrency.CurrencyName + " " + "işlem türü: "  + item.OperationType + " " + "kur birim tutarı: "+  item.CurrentValue + " " + "alınan tutar: " + item.Amount + "toplam tutar: " + item.TotalPrice);
            }
        }
        public void CustomerSaleOperationSatis()
        {
            ConsoleDbProjeEntities1 db = new ConsoleDbProjeEntities1();
            var values = db.TblOperation.Where(x => x.OperationType == "satış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID:" + item.ID + "müşteri:" + item.CustomerName + " " + item.CustomerSurname + "Döviz: " + item.TblCurrency.CurrencyName + " " + "işlem türü: " + item.OperationType + " " + "kur birim tutarı: " + item.CurrentValue + " " + "alınan tutar: " + item.Amount + "toplam tutar: " + item.TotalPrice);
            }
        }
    }
}
