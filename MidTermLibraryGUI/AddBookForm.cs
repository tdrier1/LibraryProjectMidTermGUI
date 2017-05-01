using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MidTermLibraryGUI
{
    public partial class AddBookForm : Form
    {
        private BookClass[] BookArray = new BookClass[1];

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void Write(BookClass book)
        {
            StreamWriter sw = new StreamWriter("Library.txt");
            sw.WriteLine(BookArray.Length + 1);
            sw.WriteLine(book.TitleProp);
            sw.WriteLine(book.AuthorProp);
            sw.WriteLine(book.GenreProp);
            sw.WriteLine(book.StatusProp);
            sw.WriteLine(book.DueDateProp);

            for (int i = 0; i < BookArray.Length; i++)
            {
                sw.WriteLine(BookArray[i].TitleProp);
                sw.WriteLine(BookArray[i].AuthorProp);
                sw.WriteLine(BookArray[i].GenreProp);
                sw.WriteLine(BookArray[i].StatusProp);
                sw.WriteLine(BookArray[i].DueDateProp);
            }
            sw.Close();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Library.txt");
            BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            for (int i = 0; i < BookArray.Length; i++)
            {
                BookArray[i] = new BookClass();
                BookArray[i].TitleProp = sr.ReadLine();
                BookArray[i].AuthorProp = sr.ReadLine();
                BookArray[i].GenreProp = sr.ReadLine();
                BookArray[i].StatusProp = sr.ReadLine();
                BookArray[i].DueDateProp = sr.ReadLine();
                BookArray[i].IndexProp = i;
            }
            sr.Close();
        }

        private void Display()
        {
            for(int i = 0; i <= 0; i++)
            {
                BookListBox.Items.Add(BookArray[0].ToString());
            }
        }

        private void ClearForm()
        {
            TitleInput.Text = String.Empty;
            AuthInput.Text = String.Empty;
            GenreList.Text = String.Empty;
        }

        private void AddBookClick(object sender, EventArgs e)
        {
            BookClass book = new BookClass();

            book.TitleProp = TitleInput.Text;
            book.AuthorProp = AuthInput.Text;
            book.GenreProp = GenreList.Text;

            if (string.IsNullOrEmpty(TitleInput.Text))
                {
                    MessageBox.Show("Please Enter A Title!");
                    return;
                }
              
            if (string.IsNullOrEmpty(AuthInput.Text))
                {
                    MessageBox.Show("Please Enter An Author!");
                    return;
                }
              
            if (string.IsNullOrEmpty(GenreList.Text))
                {
                    MessageBox.Show("Please Enter A Genre!");
                    return;
                }
             
            Write(book);
            Read();
            Display();
            ClearForm();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            Read();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
