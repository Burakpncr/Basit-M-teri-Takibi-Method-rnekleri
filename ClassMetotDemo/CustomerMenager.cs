using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerMenager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Ekleme işlemi tamamlandı" + " : " + "id : " + customer.id + ", Adı : " + customer.ad + ", Soyadı : " + customer.soyad);
        }
        public void CustomersList (params Customer[] customer)
        {
            foreach (var cust in customer)
            {
                Console.WriteLine(cust.id);
                Console.WriteLine(cust.ad);
                Console.WriteLine(cust.soyad);
                Console.WriteLine(cust.telefon);
                Console.WriteLine(cust.yas);
            }
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Kullanıcı Silme İşlemi Tamamlandı : " + customer.id + " No'lu müşteri silindi");
        }
    }
}
