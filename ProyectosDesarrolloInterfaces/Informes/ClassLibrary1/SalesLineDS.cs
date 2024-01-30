using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class SalesLineDS
    {

        public static List<SalesLine> GetSalesLines() {

            var customers = constructCustomers();
            var items = constructItems();

            var res = new List<SalesLine>();

            var rndGenerator = new Random();

            for (int i=1; i <=25; i++) { 
            
            var rndCustomers = "C000"+ rndGenerator.Next(1,11);
            var rndItem = "000"+ rndGenerator.Next(1,11);
                var rndQty = rndGenerator.NextDouble()*100;
                var rndUnitPrice = rndGenerator.NextDouble()*100;

                var salesLine = new SalesLine();


                salesLine.CustAccount = rndCustomers;
                salesLine.CustName = customers[rndCustomers];
                salesLine.ItemId = rndItem;
                salesLine.Description = items[rndItem];
                salesLine.Qty = (decimal)rndQty;
                salesLine.UnitPrice=(decimal)rndUnitPrice;
                salesLine.TotalPrice = salesLine.Qty * salesLine.UnitPrice;

                res.Add(salesLine);

            }
            return res;
                 
      }

        private static Dictionary<string, string> constructCustomers() { 
        var clientes = new Dictionary<string, string>() {
           
                {"C0001","Hammond" },
                { "C0002","Paco" },
                { "C0003","Josef" },
                { "C0004","Kurt" },
                { "C0005","Neil" },
                { "C0006","Eustaquio" },
                { "C0007","Hannibal" },
                { "C0008","Pikachu" },
                { "C0009","Satan" },
                { "C00010","Cianuro" },
                { "C00011","escopeto" },
                { "C00012","Atontao" }
                           
                                  
                        };

            return clientes;    
        
        }

        private static Dictionary<string, string> constructItems()
        {
            var items = new Dictionary<string, string>() {

                {"0001","Model 001" },
                { "0002","Model 002" },
                { "0003","Model 069" },
                { "0004","Model broken" },
                { "0005","Model shieet" },
                { "0006","Model modelo" },
                { "0007","Model pretor" },
                { "0008","Model Pikachu" },
                { "0009","Model Satan" },
                { "00010","Model mierder" },
                { "00011","Model matame" },
                { "00012","Matame ya" }


            };

            return items;

        }





    }
}
