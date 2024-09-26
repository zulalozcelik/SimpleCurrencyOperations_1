﻿using ConsoleDersleri_4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDersleri_4.Classes
{
    public class Sale
    {
        ConsoleDbProjeEntities1 db = new ConsoleDbProjeEntities1();
        public void MakeSale(string customerName, string customerSurname, int currencyCode, string operationType, decimal currentValue, decimal amount, decimal totalPrice)
        {
           TblOperation t = new TblOperation();
            t.CustomerName = customerName;
            t.CustomerSurname = customerSurname;
            t.CurrencyID = currencyCode;
            t.OperationType = operationType;
            t.CurrentValue = currentValue;
            t.Amount = amount;
            t.TotalPrice = totalPrice;
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOperation.Add(t);
            db.SaveChanges();
            Console.WriteLine("Satış işlemi başarılı bir şekilde gerçekleşti");
        }
    }
}
