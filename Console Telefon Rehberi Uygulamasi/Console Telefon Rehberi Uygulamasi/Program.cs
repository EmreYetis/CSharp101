using System;
using System.Collections.Generic;

namespace console_telefon_rehberi_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = 0;
            List<Contact> contactsList = new List<Contact>();
            ContactsOperations ops = new ContactsOperations();
            contactsList.Add(new Contact("Emre", "Kaan", "07777777777"));
            contactsList.Add(new Contact("Batuhan", "Yet", "08888888888"));
            contactsList.Add(new Contact("Cagatay", "Yetiş", "09999999999"));
            contactsList.Add(new Contact("Mert", "Aydın", "06666666666"));

            do
            {
                ops.ViewOptions();
                operation = Convert.ToInt16(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ops.AddContact(contactsList);
                        break;
                    case 2:
                        ops.DeleteContact(contactsList);
                        break;
                    case 3:
                        ops.UpdateContact(contactsList);
                        break;
                    case 4:
                        ops.ViewContacts(contactsList);
                        break;
                    case 5:
                        ops.ViewContact(contactsList);
                        break;
                }
            } while (Convert.ToInt16(operation) != 6);


        }
    }
}