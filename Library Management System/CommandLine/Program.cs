using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Library Management System of \n---------------- A P I I T ----------------");
        Thread.Sleep(1000);
        Console.WriteLine();

        // Hardcoded username and password
        string correctUsername = "admin";
        string correctPassword = "admin";

        // Get credentials from user
        Console.Write("Enter username: ");
        string enteredUsername = Console.ReadLine();

        Console.Write("Enter password: ");
        string enteredPassword = Console.ReadLine();

        // Check if credentials are correct
        if (enteredUsername == correctUsername && enteredPassword == correctPassword)
        {
            Console.WriteLine("Login successful!\n");

            Library library = new Library();

            // Adding students to the library
            library.Students.Add(new Student("Hannan Munas", "CB011253", "0768535555", "Hannanmunas76@gmail.com"));
            library.Students.Add(new Student("Shahiru Iduranga", "CB011584", "0743194860", "shahiru@gmail.com"));
            library.Students.Add(new Student("Lakindu Mudannayake", "CB011327", "0766615482", "lakindu@gmail.com"));
            library.Students.Add(new Student("Pulditha Wathsal", "CB011498", "0771852120", "Pulditha@gmail.com"));

            // Adding books to the library
            library.Books.Add(new Book("Rich Dad Poor Dad", "Robert Kiyosaki", "9781612681139", 2425, 1));
            library.Books.Add(new Book("Vendor of Sweats", "R K Narayan", "9780143424536", 855, 3));
            library.Books.Add(new Book("Wave", "Sonali Deraniyagala", "9781844089079", 2695, 1));
            library.Books.Add(new Book("Oliver Twist", "Charles Dickens", "9781407145457", 900, 2));

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("+ Choose an option:");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Issue Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. View Book Info");
                Console.WriteLine("6. View Student Info");
                Console.WriteLine("7. Display Borrowed Books");
                Console.WriteLine("8. Delete Book");
                Console.WriteLine("9. Exit");

                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: Add book");
                        Console.WriteLine();
                        library.AddBook();
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: Add Student");
                        Console.WriteLine();
                        library.AddStudent();
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: Issue Book");
                        Console.WriteLine();
                        library.IssueBook();
                        break;

                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: Return Book");
                        Console.WriteLine();
                        library.ReturnBook();
                        break;

                    case "5":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: View Book Info");
                        Console.WriteLine();
                        library.ViewBookInfo();
                        break;

                    case "6":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: View Student Info");
                        Console.WriteLine();
                        library.ViewStudentInfo();
                        break;

                    case "7":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: View Borrowed Books Info");
                        Console.WriteLine();
                        library.DisplayBorrowedBooks();
                        break;

                    case "8":
                        Console.WriteLine();
                        Console.WriteLine("≡ You chose: Delete Book");
                        Console.WriteLine();
                        Console.Write("Enter ISBN of the book to delete: ");
                        string isbnToDelete = Console.ReadLine();
                        library.DeleteBook(isbnToDelete);
                        break;

                    case "9":
                        Console.WriteLine();
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Console.WriteLine();
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        Console.WriteLine();
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Incorrect username or password. Exiting program.");
        }
        Console.WriteLine();
    }
}
