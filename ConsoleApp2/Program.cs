using ConsoleApp2;

void GetMenu()
{
    Console.WriteLine($"1) Создать контакт в телефонной книге");
    Console.WriteLine($"2)Удалить контакт из телефонной книги");
    Console.WriteLine($"3)Удалить все контакты ");
    Console.WriteLine($"4)Показать все контакты");
}
void Menu()
{
    PhoneBook phone = new PhoneBook();
    while (true)
    {
        GetMenu();
        Console.WriteLine();
        string a = Console.ReadLine();
        int menu = int.Parse(a);
        if (menu == 1)
        {
            Console.WriteLine($"Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine($"Введите номер");
            string namber = Console.ReadLine();
            Contact contact = new Contact(namber, name, surname);
            Console.WriteLine();
            phone.SetAContact(contact);
        }
        else if (menu == 2)
        {
            Console.WriteLine();
            Console.WriteLine($"Введите номер");
            string namber = Console.ReadLine();
            phone.DeleteContact(namber);
        }
        else if (menu == 3)
        {
            phone.DeleteOllContact();
        }
        else if (menu == 4)
        {
            phone.GetOllContacts();
        }
    }
}
Menu();