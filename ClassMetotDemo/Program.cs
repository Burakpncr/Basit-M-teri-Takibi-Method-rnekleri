using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.ad = "Burak";
            customer1.soyad = "Pancar";
            customer1.telefon = "05548988783";
            customer1.yas = 21;
           
            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.ad = "Ahmet";
            customer2.soyad = "Yılmaz";
            customer2.telefon = "05444444444";
            customer2.yas = 23;

            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.AddCustomer(customer2);
            customerMenager.CustomersList(customer1,customer2);
            customerMenager.CustomerDelete(customer1);
        }
    }
}
