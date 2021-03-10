using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Customer cs1 = new Customer();
            cs1.Id=1;
            cs1.Name = "Talha";
            cs1.FamilyName = "Budak";
            cs1.Yaş = 24;

            
            Customer cs2 = new Customer();
            cs2.Id = 2;
            cs2.Name = "Burak";
            cs2.FamilyName = "Budak";
            cs2.Yaş = 22;

            Customer cs3 = new Customer();
            cs3.Id = 3;
            cs3.Name = "Niyazi";
            cs3.FamilyName = "Budak";
            cs3.Yaş = 53;

            Customer cs4 = new Customer();
            cs4.Id = 4;
            cs4.Name = "Nuran";
            cs4.FamilyName = "Budak";
            cs4.Yaş = 48;

            Customer cs5 = new Customer();
            cs5.Id = 5;
            cs5.Name = "Rümeysa";
            cs5.FamilyName = "Budak";
            cs5.Yaş = 24;

            Customer[] customers = new Customer[] { cs1, cs2, cs3, cs4, cs5 };
            CustomerManager.List(customers);
        }
    }
}
