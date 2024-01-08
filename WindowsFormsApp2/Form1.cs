using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        private string filename = "tips_texter.txt";
        private string separator = "###";
        public Form1()
        {
            InitializeComponent();
            loadBooksFromFile();
            refreshListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suggestBook();
        }

        private void suggestBook()
        {

            Random random = new Random();
            int index = random.Next(books.Count);
            listView1.SelectedIndices.Clear();
            listView1.SelectedIndices.Add(index);
            listView1.Items[index].Selected = true;
            listView1.Focus();
            label1.Text = books[index].ToString();
        }

        private void loadBooksFromFile()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), filename);

            StreamReader sr = new StreamReader(path);
            String line = sr.ReadLine();
            while (line != null)
            {
                string[] words = line.Split(new string[] {separator}, StringSplitOptions.None);
                Boolean isBorrowed = false;
                if (words[3] == "true") isBorrowed =true;
                Book book = new Book(words[0], words[1], words[2], isBorrowed);
                books.Add(book);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void saveBooksToFile()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), filename);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Create(path).Close();
            
            StreamWriter sw = new StreamWriter(path);
            foreach (Book book in books)
            {
                string borrowed = "false";
                if (book.IsBorrowed) borrowed = "true";
                sw.WriteLine($"{book.Title}{separator}{book.Author}{separator}{book.Genre}{separator}{borrowed}");
            }
            sw.Close();
        }

        private void refreshListView()
        {
            listView1.Items.Clear();
            foreach(Book book in books)
            {
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.IsBorrowed.ToString());
                listView1.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (newName.Text == "")
            {
                MessageBox.Show("Please enter a title");
            }
            else if (newAuthor.Text == "")
            {
                MessageBox.Show("Please enter an author");
            }
            else if (newGenre.Text == "")
            {
                MessageBox.Show("Please enter a title");
            }
            else
            {
                books.Add(new Book(newName.Text, newAuthor.Text, newGenre.Text, newBorrowed.Checked));
                saveBooksToFile();
                refreshListView();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count >0)
            {
                books.RemoveAt(listView1.SelectedIndices[0]);
                saveBooksToFile();
                refreshListView();
            }

        }
    }
}
