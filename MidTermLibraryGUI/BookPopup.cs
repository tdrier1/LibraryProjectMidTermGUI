using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MidTermLibraryGUI
{
    public partial class BookPopup : Form
    {
        private void BookPopup_Load(object sender, EventArgs e)
        {
            BookClass book = new BookClass();

            BookHelper.Read();

            BookImage.SizeMode = PictureBoxSizeMode.StretchImage;

            var result = Regex.Match(BookClass.SelectProp, @"\d+$").Value;

            int index1 = Convert.ToInt32(result);

            this.CheckoutLabel.Text = Program.BookArray[index1].TitleProp;
        }

        public BookPopup()
        {
            InitializeComponent();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            BookClass book = new BookClass();
            BookHelper.Read();

            var result = Regex.Match(BookClass.SelectProp, @"\d+$").Value;

            int index1 = Convert.ToInt32(result);

            Program.BookArray[index1].StatusProp = "Checked Out";
            Program.BookArray[index1].DueDateProp = DateTime.Now.AddDays(14).ToString("MM/dd/yy");

            BookHelper.Write(book);
            

            this.Close();
        }

        private void ExitInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
