using System;

namespace console_telefon_rehberi_uygulamasi
{
    class Contact
    {
        private string name;
        private string surName;
        private string number;
        public Contact(string f_name, string l_name, string phone)
        {
            this.name = f_name;
            this.surName = l_name;
            this.number = phone;
        }

        public string getFirstName()
        {
            return this.name;
        }
        public string getLastName()
        {
            return this.surName;
        }
        public string getPhone()
        {
            return this.number;
        }
        public void setFirstName(string name)
        {
            this.name = name;
        }
        public void setLastName(string name)
        {
            this.surName = name;
        }
        public void setPhone(string phone)
        {
            this.number = phone;
        }
        public void ContactDetails()
        {
            Console.WriteLine("İsim: " + this.name);
            Console.WriteLine("Soyisim: " + this.surName);
            Console.WriteLine("Telefon Numarası: " + this.number);
        }

    }

}