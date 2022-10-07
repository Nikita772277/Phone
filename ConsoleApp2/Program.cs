using ConsoleApp2;

void GetMenu()
{
    Console.WriteLine($"Создать контакт в телефонной книге");
    Console.WriteLine($"Удалить контакт из телефонной книги");
    Console.WriteLine($"Удалить все контакты ");
    Console.WriteLine($"Показать все контакты");
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
            phone.SetAContact(contact);
        }
        else if (menu == 2)
        {
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