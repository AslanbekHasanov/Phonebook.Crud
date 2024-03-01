// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Phonebook.Crud.Model;
using Phonebook.Crud.Services;
bool @cantinue = true;
PhoneBookService phoneBookService = new PhoneBookService();

while (@cantinue)
{
    Console.Clear();
    Console.WriteLine("======== Welcome to my Project ========");
    Console.WriteLine("1. Create new phone book");
    Console.WriteLine("2. Update phone book");
    Console.WriteLine("3. Delete one phone book");
    Console.WriteLine("4. Get one phone book");
    Console.WriteLine("5. Get all phone book information\n");

    Console.Write("Emter your command(1, 2, 3 ... ) : ");
    int command = Convert.ToInt32(Console.ReadLine());

    if(command == 1)
    {
        Console.Clear();
        Console.WriteLine("=== Create new phone book ===\n");
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter your phone: ");
        string? phone = Console.ReadLine();

        bool result = phoneBookService.Create(name, phone);

        if (result)
        {
            Console.WriteLine("Creat !");
        }
        else
        {
            Console.WriteLine("Created before!");
        }
    }
    else if(command == 2)
    {
        Console.Clear();
        Console.WriteLine("=== Update phone book ===\n");

        Console.Write("Enter your exsist id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Id = id;
        Console.Write("Enter your new name: ");
        phoneBook.Name = Console.ReadLine();
        Console.Write("Enter your new phone: ");
        phoneBook.Phone = Console.ReadLine();

        bool result = phoneBookService.Update(id, phoneBook);

        if (result)
        {
            Console.WriteLine("Updated");
        }
        else
        {
            Console.WriteLine("Not Updated, Not Found");
        }


    }
    else if (command == 3)
    {
        Console.Clear();
        Console.WriteLine("=== Delete one phone book ===\n");
        Console.Write("Enter id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        bool result = phoneBookService.DeletePhoneBookById(id);
        if (result)
        {
            Console.WriteLine("Deleted");
        }
        else
        {
            Console.WriteLine("Not Found");
        }

    }
    else if (command == 4)
    {
        Console.Clear();
        Console.WriteLine("=== Get one phone book ===\n");
        Console.Write("Enter id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        PhoneBook? phoneBook = phoneBookService.ReadById(id);
        if (phoneBook is not null)
        {
            Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name} {phoneBook.Phone}");
        }
        else
        {
            Console.WriteLine("Not Found !");
        }
    }

    else if (command == 5)
    {
        Console.Clear();
        Console.WriteLine("=== Get all phone book information ===\n");
        phoneBookService.ReadAllPhoneBooks();

    }

    Console.Write("\nWill you continue(YES 👍 || NO 👎): ");
    string cantinueOperation = Console.ReadLine();
    if (cantinueOperation.ToLower() == "yes")
    {
        @cantinue = true;
    }
    else if(cantinueOperation.ToLower() == "no")
    {
        @cantinue = false;
    }
}
Console.WriteLine("\nThe End");

