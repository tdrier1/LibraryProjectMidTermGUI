namespace MidTermLibraryGUI
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorInput = new System.Windows.Forms.Label();
            this.GenreInput = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.AuthInput = new System.Windows.Forms.TextBox();
            this.SubmitBook = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.GenreList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // AuthorInput
            // 
            this.AuthorInput.AutoSize = true;
            this.AuthorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInput.Location = new System.Drawing.Point(30, 289);
            this.AuthorInput.Name = "AuthorInput";
            this.AuthorInput.Size = new System.Drawing.Size(82, 29);
            this.AuthorInput.TabIndex = 1;
            this.AuthorInput.Text = "Author";
            // 
            // GenreInput
            // 
            this.GenreInput.AutoSize = true;
            this.GenreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreInput.Location = new System.Drawing.Point(30, 462);
            this.GenreInput.Name = "GenreInput";
            this.GenreInput.Size = new System.Drawing.Size(80, 29);
            this.GenreInput.TabIndex = 2;
            this.GenreInput.Text = "Genre";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(127, 121);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(194, 26);
            this.TitleInput.TabIndex = 3;
            // 
            // AuthInput
            // 
            this.AuthInput.Location = new System.Drawing.Point(127, 289);
            this.AuthInput.Name = "AuthInput";
            this.AuthInput.Size = new System.Drawing.Size(194, 26);
            this.AuthInput.TabIndex = 4;
            // 
            // SubmitBook
            // 
            this.SubmitBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SubmitBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBook.ForeColor = System.Drawing.Color.Black;
            this.SubmitBook.Location = new System.Drawing.Point(358, 625);
            this.SubmitBook.Name = "SubmitBook";
            this.SubmitBook.Size = new System.Drawing.Size(300, 125);
            this.SubmitBook.TabIndex = 6;
            this.SubmitBook.Text = "Submit";
            this.SubmitBook.UseVisualStyleBackColor = false;
            this.SubmitBook.Click += new System.EventHandler(this.AddBookClick);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.Black;
            this.MainMenu.Location = new System.Drawing.Point(770, 625);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(300, 125);
            this.MainMenu.TabIndex = 7;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // BookListBox
            // 
            this.BookListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookListBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 19;
            this.BookListBox.Location = new System.Drawing.Point(358, 106);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(712, 460);
            this.BookListBox.TabIndex = 8;
            // 
            // GenreList
            // 
            this.GenreList.FormattingEnabled = true;
            this.GenreList.Items.AddRange(new object[] {
            "Fantasy",
            "Childrens",
            "Fiction",
            "SciFi",
            "Drama",
            "Romance",
            "Mystery",
            "Action"});
            this.GenreList.Location = new System.Drawing.Point(127, 462);
            this.GenreList.Name = "GenreList";
            this.GenreList.Size = new System.Drawing.Size(194, 28);
            this.GenreList.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "Add A Book to Our Library";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(854, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your submitted books";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 795);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenreList);
            this.Controls.Add(this.BookListBox);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.SubmitBook);
            this.Controls.Add(this.AuthInput);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.GenreInput);
            this.Controls.Add(this.AuthorInput);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AuthorInput;
        private System.Windows.Forms.Label GenreInput;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.TextBox AuthInput;
        private System.Windows.Forms.Button SubmitBook;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.ComboBox GenreList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}