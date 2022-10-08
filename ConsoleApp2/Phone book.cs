using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();
        public void SetAContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void DeleteContact(string number)
        {


            foreach (Contact contact in contacts)
            {
                if (contact.GetNumber() == number)
                {
                    contacts.Remove(contact);
                    return;
                }
                else
                {
                    Console.WriteLine($"нет такого номера");
                    Console.WriteLine();
                }
            }
        }
        public void ViewAllContacts()
        {
            if (contacts is null || contacts.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"список контактов пуст");
                Console.WriteLine();
            }
            else foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact);
                }
        }
        public void DeleteOllContact()
        {
            contacts = new List<Contact>();
            Console.WriteLine();
            Console.WriteLine($"Все контакты удалены");
            Console.WriteLine();
        }
        public void GetOllContacts()
        {
            if (contacts is null || contacts.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"список контактов пуст");
            }
            else foreach (Contact contact in contacts)
                {
                    contact.GetInformation();
                }
        }
    }
}
