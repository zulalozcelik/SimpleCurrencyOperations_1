
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ConsoleDersleri_4.Classes;
using ConsoleDersleri_4.Model;


namespace ConsoleDersleri_4
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ConsoleDbProjeEntities1 db = new ConsoleDbProjeEntities1();
            GetCurrency getCurrency = new GetCurrency();
            Sale sale = new Sale();

            void CurrencyList()
            {
                Console.WriteLine();
                Console.WriteLine("Döviz listesi:");
                Console.WriteLine();

                var values = db.TblCurrency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ID + " " + item.CurrencyName);
                }

            }

            void CurrentCurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Güncel Kur Listesi");
                Console.WriteLine();
                var values = db.TblCurrencyValue.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine( "Döviz: " + item.TblCurrency.CurrencyName + " Alış:" + item.CurrencyBuying + " Satış:" + item.CurrencySelling);
                }

            }

            void GetCurrencyClass()
            {
                
                getCurrency.SaveCurrencyDolar();
                getCurrency.SaveCurrencyEuro();
                getCurrency.SaveCurrencyPound();
            }


            Console.WriteLine("döviz işlemlerine hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("Mevcut Kullanıcı: Admin" + "    Tarih:" + DateTime.Now.ToShortDateString());
            Console.WriteLine("yapmak istediğiniz işlemi seçin");
            Console.WriteLine();
            Console.WriteLine("1-Döviz Listesi");
            Console.WriteLine("2-Güncel kurlar");
            Console.WriteLine("3-Satış yap");
            Console.WriteLine("4-Müşterilere yapılan satış hareketleri");
            Console.WriteLine("5-Müşterilerden alınan satış hareketleri");
            Console.WriteLine("6-Kurları veri tabanına kaydet");
            Console.WriteLine("7-Çıkış yap");

            Console.WriteLine("İşlem Numarası:");

            string choose;
            choose = Console.ReadLine();
            if (choose =="1"|| choose == "01")
            {
                CurrencyList();
            }
            if (choose == "2" || choose == "02")
            {
                CurrentCurrency();
            }
            if (choose == "3" || choose == "03")
            {
                Console.WriteLine();
                Console.Write("Müşteri Adı:");
                string customerName = Console.ReadLine();
                Console.Write("Müşteri Soyadı:");
                string customerSurname = Console.ReadLine();
                Console.Write("Döviz kodu:");
                int currencyCode =int.Parse(Console.ReadLine());
                Console.Write("işlem türü:");
                string operationType = Console.ReadLine();
                Console.Write("güncel kur  değeri:");
                decimal currentValue = decimal.Parse(Console.ReadLine());
                Console.Write("Alınacak tutar");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.Write("toplam ücret");
                decimal totalAmount = decimal.Parse(Console.ReadLine());

                sale.MakeSale(customerName, customerSurname, currencyCode, operationType, currentValue, amount, totalAmount);
            }
            if (choose == "4"| choose =="04")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationAlis();
            }
            if (choose == "5" | choose == "05")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationSatis();
            }
            if (choose == "6" || choose == "06")
            {
                GetCurrencyClass();
                Console.WriteLine("Dövizler başarılı bir şekilde veri tabanına kaydedildi");
            }
            if (choose == "7" | choose == "07")
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}




