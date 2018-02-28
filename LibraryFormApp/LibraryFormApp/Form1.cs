using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new Book(titleInput.Text, authorInput.Text, Convert.ToInt32(yearInput.Text));
            booksCombo.Items.Clear();
            foreach (var book in Book.bookList)
            {
                booksCombo.Items.Add(book.Title);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (var book in Book.bookList)
            {
                if(book.Title == booksCombo.SelectedItem.ToString())
                {
                    Book.bookList.Remove(book);
                    break;
                }
            }
            booksCombo.Items.Clear();
            foreach (var book in Book.bookList)
            {
                booksCombo.Items.Add(book.Title);
            }
        }
    }
    class Book
    {

        public static List<Book> bookList = new List<Book>();
        public string Title;
        public string Author;
        public int Year;
        public Book(string _title, string _author, int _year)
        {
            this.Title = _title;
            this.Author = _author;
            this.Year = _year;
            bookList.Add(this);
        }
    }
}
