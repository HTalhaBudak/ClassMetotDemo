using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    
    class CustomerManager
    {

        static public void Add(Customer customer)
        { 
            Console.WriteLine("Müşteri Eklendi");

        }
       static public string Delete(int Id)
        {
            //Id den isim bulundu.
            //Silme işlemleri yapıldı.
            return  "Kişi kişisi silindi.";
        }

       static  public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name+"\n");
            }



        }
    }
}
