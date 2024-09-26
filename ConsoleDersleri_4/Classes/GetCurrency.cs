using ConsoleDersleri_4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleDersleri_4.Classes
{
    public class GetCurrency
    {
        ConsoleDbProjeEntities1 db = new ConsoleDbProjeEntities1();
        public void SaveCurrencyDolar()
        {

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string dolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlis = dolarAlis.Replace(".", ",");

            string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarSatis=dolarSatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 2;
            t.CurrencyBuying = decimal.Parse(dolarAlis);
            t.CurrencySelling = decimal.Parse(dolarSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

        }
        public void SaveCurrencyEuro()
        {

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlis = euroAlis.Replace(".", ",");

            string eurosatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            eurosatis = eurosatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 1;
            t.CurrencyBuying = decimal.Parse(euroAlis);
            t.CurrencySelling = decimal.Parse(eurosatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

        }
        public void SaveCurrencyPound()
        {

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string poundAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            poundAlis = poundAlis.Replace(".", ",");

            string poundSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            poundSatis = poundSatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 4;
            t.CurrencyBuying = decimal.Parse(poundAlis);
            t.CurrencySelling = decimal.Parse(poundSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

        }
    }
}
