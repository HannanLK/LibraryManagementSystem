using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.CLASSES;
using MySql.Data.MySqlClient;

namespace Library_Management_System.DATABASE
{
    public class dataBase
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int port;

        public dataBase() {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "lms_db";
            uid = "root";
            password = "admin";
            port = 3308;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //opening the connection to the data base 
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
                
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Closing the connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //ADD BOOK - inserting book details to DB (book - table)
        public void insertBook(Book book)
        {
            string query = "INSERT INTO Book(book_title, book_author, book_isbn, book_quantity, book_price) VALUES ('" + book.Title + "', '" + book.Author + "', '" + book.ISBN + "', " + book.Quantity + ", " + book.Price + ")";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int n = cmd.ExecuteNonQuery();
                MessageBox.Show("result = " + n);

                //close connection
                this.CloseConnection();
            }
        }

        //ADD STUDENT - inserting student details to DB (student - table)
        public void insertStudent(Student student)
        {
            string query = "INSERT INTO Student(student_name, student_id, student_contact, student_email) VALUES ('" + student.Name + "', '" + student.ID + "', '" + student.Contact + "', '" + student.Email + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand( query, connection);
                int m = cmd.ExecuteNonQuery();

                MessageBox.Show("result = " + m);
                this.CloseConnection();
            }
        }

        //VIEW BOOK INFO - Function to load book details in the (book table) to the data grid view
        public void LoadAllBooks(DataGridView dataGridView)
        {
            string query = "SELECT * FROM book";

            if (this.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message);
                }
                this.CloseConnection();
            }
        }

        //VIEW BOOK INFO - Function to search and load data in the (book - table) to datagridview
        public DataTable SearchAndLoadData(string searchText)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM book WHERE book_title LIKE @SearchText OR book_author LIKE @SearchText OR book_isbn LIKE @SearchText";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }

                this.CloseConnection();
            }

            return dataTable;
        }

        //VIEW BOOK INFO - Function to update database (book - table)
        public void updateBook(Book book)
        {
            string query = "UPDATE book " +
                           "SET book_title = @BookTitle, book_author = @BookAuthor, " +
                           "book_quantity = @BookQuantity, book_price = @BookPrice " +
                           "WHERE book_isbn = @BookISBN";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BookTitle", book.Title);
                    cmd.Parameters.AddWithValue("@BookAuthor", book.Author);
                    cmd.Parameters.AddWithValue("@BookQuantity", book.Quantity);
                    cmd.Parameters.AddWithValue("@BookPrice", book.Price);
                    cmd.Parameters.AddWithValue("@BookISBN", book.ISBN);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book record updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given book ISBN.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating book record: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        //VIEW BOOK INFO - Function to delete data from data base
        public void DeleteBook(string bookISBN)
        {
            string query = "DELETE FROM book WHERE book_isbn = @BookISBN";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BookISBN", bookISBN);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given book ISBN.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting book record: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        //VIEW STUDENT INFO - Function to search and load data in the (student - table) to datagridview
        public DataTable SearchStudentData(string searchText)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM student WHERE student_name LIKE @SearchText OR student_id LIKE @SearchText OR student_contact LIKE @SearchText";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }

                this.CloseConnection();
            }

            return dataTable;
        }

        //VIEW STUDENT INFO - Function to load student details in the (student - table) to datagridview
        public void LoadAllStudents(DataGridView dataGridView)
        {
            string query = "SELECT * FROM student";

            if (this.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message);
                }
                this.CloseConnection();
            }
        }

        //VIEW STUDENT INFO - Function to update book details in the data base (student - table)
        public void UpdateStudent(Student student)
        {
            string query = "UPDATE student " +
                           "SET student_name = @StudentName, student_contact = @StudentContact, " +
                           "student_email = @StudentEmail " +
                           "WHERE student_id = @StudentID";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@StudentName", student.Name);
                    cmd.Parameters.AddWithValue("@StudentContact", student.Contact);
                    cmd.Parameters.AddWithValue("@StudentEmail", student.Email);
                    cmd.Parameters.AddWithValue("@StudentID", student.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student record updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given student ID.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating student record: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        //VIEW STUDENT INFO - Delete student details in the data base (student - table)
        public void DeleteStudent(string studentID)
        {
            string query = "DELETE FROM student WHERE student_id = @StudentID";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given student ID.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting student record: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        //Issue Book - Substracting Book quantity when a book is issued
        public void SubtractBookQuantity(int bookId, int quantityToSubtract)
        {
            string query = "UPDATE book SET book_quantity = book_quantity - @QuantityToSubtract WHERE id = @BookId";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@QuantityToSubtract", quantityToSubtract);
                    cmd.Parameters.AddWithValue("@BookId", bookId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Quantity subtracted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to subtract quantity. Book ID not found.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error subtracting quantity: " + ex.Message);
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        //Return Book - increase book quantity when a book is returned
        public void ReturnBookQuantity(int bookId, int quantityToReturn)
        {
            string query = "UPDATE book SET book_quantity = book_quantity + @QuantityToReturn WHERE id = @BookId";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuantityToReturn", quantityToReturn);
                cmd.Parameters.AddWithValue("@BookId", bookId);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book return successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to return Book. Book ID not found.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error return Book: " + ex.Message);
                }

                this.CloseConnection();
            }
        }

        //Book Availability - Function to show book availability by the Quantity
        public DataTable FilterBooksByQuantity(bool showAvailable)
        {
            DataTable dataTable = new DataTable();
            string query;

            if (showAvailable)
            {
                query = "SELECT * FROM book WHERE book_quantity > 0";
            }
            else
            {
                query = "SELECT * FROM book WHERE book_quantity <= 0";
            }

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }

                this.CloseConnection();
            }

            return dataTable;
        }

        //*********************************************** for calculation purposes ************************************************************

        //returned book is saved in a bookreturn table in the data base and send to book table.
        public void InsertBookReturn(int bookId, int quantityToSubtract, string btitle, string bauthor, string bisbn, int bquantity, string studentNo)
        {
            string query = "INSERT INTO bookreturn(book_id, quantity_subtracted, book_title, book_author, book_isbn, book_quantity, student_no) " +
                           "VALUES (@BookId, @QuantitySubtracted, @BookTitle, @BookAuthor, @BookISBN, @BookQuantity, @StudentNo)";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@QuantitySubtracted", quantityToSubtract);
                    cmd.Parameters.AddWithValue("@BookTitle", btitle);
                    cmd.Parameters.AddWithValue("@BookAuthor", bauthor);
                    cmd.Parameters.AddWithValue("@BookISBN", bisbn);
                    cmd.Parameters.AddWithValue("@BookQuantity", bquantity);
                    cmd.Parameters.AddWithValue("@StudentNo", studentNo);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book return record inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert book return record.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error inserting book return record: " + ex.Message);
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        //the saved data in the bookreturn table will be deleted then
        public void DeleteBookReturnRecord(int bookId)
        {
            string query = "DELETE FROM bookreturn WHERE book_id = @BookId";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BookId", bookId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book return record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given book ID.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting book return record: " + ex.Message);
                }

                this.CloseConnection();
            }
        }

    }
}
