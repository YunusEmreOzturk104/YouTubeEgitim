using System;

namespace YouTubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Id = 1;
            //customer.City = "Elazığ";
            //CreditManager creditManager = new CreditManager();
            //creditManager.Calculate();
            //creditManager.Save(customer);
            //CustomerManager customerManager = new CustomerManager(customer);
            //customerManager.Save();
            //customerManager.Delete();
            //Company company = new Company();
            //company.Id = 1;
            //company.textNumber = "10000";
            //company.companyName = "Arçelik";
            //CustomerManager customerManager2 = new CustomerManager(new Company());
            //Person person = new Person();
            //Customer c1 = new Customer();
            //Customer c2 = new Customer();
            //Customer c3 = new Customer();
            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager() );
            CustomerManager customerManager2 = new CustomerManager(new Customer(), new MilitaryCreditManager());
            Console.ReadLine();
        }
    }
    class CreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Hesaplandı");
        }
        public void Save(Customer customer)
        {
            Console.WriteLine("Kredi verildi");
        }
    }

    interface ICreditManager
    {
        void calculate();
        void Save();
    }
    class TeacherCreditManager : ICreditManager
    {
        public void calculate()
        {
            Console.WriteLine("Öğretmen krredisi hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Öğretmen krredisi kaydedildi");
        }
    }

    class MilitaryCreditManager : ICreditManager
    {
        public void calculate()
        {
            Console.WriteLine("Asker krredisi hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Asker krredisi kaydedildi");
        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi oluşturuldu");
        }
        public int Id { get; set; }
       
        
        public string City { get; set; }
    }
    class Person:Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string NationalIdentity { get; set; }
    }
    class Company:Customer
    {
        public string companyName { get; set; }
        public string textNumber { get; set; }
    }

    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManger;
        public CustomerManager(Customer customer, ICreditManager creditManger)
        {
            _customer = customer;
            _creditManger = creditManger;
        }
        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi");
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri silindi");
        }
    }
}
