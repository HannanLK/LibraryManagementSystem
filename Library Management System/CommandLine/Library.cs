using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Library
{
    //OOP - ENCAPSULATION, hiding internal details
    private List<Book> books = new List<Book>();
    private List<Student> students = new List<Student>();

    public List<Book> Books { get { return books; } }
    public List<Student> Students { get { return students; } }

    //**************************** ADD BOOK *********************************************
    public void AddBook()
    {
        Console.WriteLine("- Enter book details:");

        Console.Write("Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Author: ");
        string author = Console.ReadLine();

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();

        // Check if the book already exists in the library
        if (Books.Any(book => book.ISBN == isbn))
        {
            Console.WriteLine("Book with ISBN {0} already exists in the library.", isbn);
        }
        else
        {
            Console.Write("Price: ");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid input. Please enter a valid price.");
                Console.Write("Price: ");
            }

            Console.Write("Quantity: ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Invalid input. Please enter a valid quantity.");
                Console.Write("Quantity: ");
            }

            // Book does not exist, add it to the library
            Book newBook = new Book(title, author, isbn, price, quantity);
            Books.Add(newBook);
            Console.WriteLine();
            Console.WriteLine("Book added successfully!");
        }

    }

    //************************** ADD STUDENT *********************************************
    public void AddStudent()
    {
        Console.WriteLine("- Enter student details:");

        Console.Write("Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Student ID: ");
        string studentId = Console.ReadLine();

        // Check if the student already exists in the library
        if (Students.Any(student => student.StudentID == studentId))
        {
            Console.WriteLine();
            Console.WriteLine("Student with ID {0} is already a member of the library.", studentId);
        }
        else
        {
            // Student does not exist, add them to the library
            Console.Write("Contact Number: ");
            string contactNumber = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Student newStudent = new Student(name, studentId, contactNumber, email);
            Students.Add(newStudent);

            Console.WriteLine();
            Console.WriteLine("Student added successfully!");
        }

    }
    
    //***************************** ISSUE BOOK *************************************************
    public void IssueBook()
    {
        Console.WriteLine("- Enter book and student details:");

        Console.Write("Book ISBN: ");
        string isbn = Console.ReadLine();

        Console.Write("Student ID: ");
        string studentId = Console.ReadLine();

        // Check if the book exists
        Book bookToIssue = Books.Find(book => book.ISBN == isbn);

        // Check if the student exists
        Student student = Students.Find(s => s.StudentID == studentId);
        Console.WriteLine();

        if (bookToIssue != null && student != null)
        {
            Console.WriteLine($"Book found: {bookToIssue.Title} by {bookToIssue.Author}");
            Console.WriteLine($"Student found: {student.Name} (ID: {student.StudentID})");

            Console.Write("Issue book? (y/n): ");
            string issueChoice = Console.ReadLine();

            if (issueChoice.ToLower() == "y")
            {
                if (bookToIssue.Quantity > 0)
                {
                    // Decrement statement
                    bookToIssue.Quantity--;
                    Console.WriteLine();
                    Console.WriteLine("Book issued successfully!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, the book is out of stock.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Book not issued.");
            }
        }
        else
        {
            Console.WriteLine("Book or student not found. Unable to issue the book.");
        }
    }

    //***************************** RETURN BOOK ****************************************
    public void ReturnBook()
    {
        Console.WriteLine("- Enter book and student details:");

        Console.Write("Book ISBN: ");
        string isbn = Console.ReadLine();

        Console.Write("Student ID: ");
        string studentId = Console.ReadLine();

        // Check if the book exists
        Book returnedBook = Books.Find(book => book.ISBN == isbn);

        // Check if the student exists
        Student student = Students.Find(s => s.StudentID == studentId);
        Console.WriteLine();

        if (returnedBook != null && student != null)
        {
            Console.WriteLine($"Book found: {returnedBook.Title} by {returnedBook.Author}");
            Console.WriteLine($"Student found: {student.Name} (ID: {student.StudentID})");

            Console.Write("Return book? (y/n): ");
            string returnChoice = Console.ReadLine();

            if (returnChoice.ToLower() == "y")
            {
                // Incrimnt statement
                returnedBook.Quantity++;
                Console.WriteLine();
                Console.WriteLine("Book returned successfully!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Book not returned.");
            }
        }
        else
        {
            Console.WriteLine("Book or student not found. Unable to return the book.");
        }
    }

    //***************************** VIEW BOOK *************************************
    public void ViewBookInfo()
    {
        Console.WriteLine("- Book information:");

        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine($"Price: {book.Price:C}");
            Console.WriteLine($"Availability: {(book.Quantity > 0 ? "Yes" : "No")}");
            Console.WriteLine();
        }
    }

    //***************************** VIEW STUDENT ************************************
    public void ViewStudentInfo()
    {
        Console.WriteLine("- Student information:");

        foreach (var student in Students)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Student ID: {student.StudentID}");
            Console.WriteLine($"Contact Number: {student.ContactNumber}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine();
        }
    }

    //****************************** DISPLAY BORROWED BOOKS ************************
    public void DisplayBorrowedBooks()
    {
        Console.WriteLine("Books Borrowed by Students:");
        Console.WriteLine("--------------------------");

        // Iterate through students
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student.Name} (ID: {student.StudentID})");

            // Get books borrowed by the student
            var borrowedBooks = books.Where(book => book.BorrowedBy == student).ToList();

            // Display borrowed books
            if (borrowedBooks.Any())
            {
                Console.WriteLine("Borrowed Books:");
                foreach (var book in borrowedBooks)
                {
                    Console.WriteLine();
                    Console.WriteLine($"- Title: {book.Title}, Author: {book.Author}");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No books borrowed.");
            }

            Console.WriteLine();
        }
    }

    //****************************** DELETE BOOK ************************************
    public void DeleteBook(string isbn)
    {
        // Find the book with the specified ISBN
        Book bookToDelete = books.FirstOrDefault(book => book.ISBN == isbn);

        if (bookToDelete != null)
        {
            // Display book information and confirm deletion
            Console.WriteLine();
            Console.WriteLine($"Book found with ISBN {isbn}:");
            Console.WriteLine($"Title: {bookToDelete.Title}, Author: {bookToDelete.Author}");
            Console.WriteLine();
            Console.Write("Do you want to delete this book? (y/n): ");

            // Get user input
            string userInput = Console.ReadLine();

            // Check user's decision
            if (userInput.ToLower() == "y")
            {
                // Remove the book from the list
                books.Remove(bookToDelete);
                Console.WriteLine();
                Console.WriteLine($"Book with ISBN {isbn} has been deleted.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Deletion canceled. Book has not been deleted.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Book with ISBN {isbn} not found.");
        }
    }

}
