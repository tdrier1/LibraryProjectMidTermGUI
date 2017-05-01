namespace MidTermLibraryGUI
{
    partial class BookInv
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.InvBox = new System.Windows.Forms.ListBox();
            this.BookInvAuthTxt = new System.Windows.Forms.TextBox();
            this.BookInvTitleTxt = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.BookInvTitle = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.GenreList = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(61, 656);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(300, 125);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // InvBox
            // 
            this.InvBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InvBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvBox.FormattingEnabled = true;
            this.InvBox.ItemHeight = 19;
            this.InvBox.Location = new System.Drawing.Point(373, 142);
            this.InvBox.Name = "InvBox";
            this.InvBox.Size = new System.Drawing.Size(1050, 498);
            this.InvBox.TabIndex = 1;
            this.InvBox.DoubleClick += new System.EventHandler(this.InvBox_SelectedIndexChanged);
            // 
            // BookInvAuthTxt
            // 
            this.BookInvAuthTxt.Location = new System.Drawing.Point(113, 322);
            this.BookInvAuthTxt.Name = "BookInvAuthTxt";
            this.BookInvAuthTxt.Size = new System.Drawing.Size(233, 26);
            this.BookInvAuthTxt.TabIndex = 2;
            // 
            // BookInvTitleTxt
            // 
            this.BookInvTitleTxt.Location = new System.Drawing.Point(113, 142);
            this.BookInvTitleTxt.Name = "BookInvTitleTxt";
            this.BookInvTitleTxt.Size = new System.Drawing.Size(233, 26);
            this.BookInvTitleTxt.TabIndex = 3;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(25, 142);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 29);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // AuthLabel
            // 
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthLabel.Location = new System.Drawing.Point(25, 318);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(82, 29);
            this.AuthLabel.TabIndex = 6;
            this.AuthLabel.Text = "Author";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(23, 504);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(80, 29);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Genre";
            // 
            // BookInvTitle
            // 
            this.BookInvTitle.AutoSize = true;
            this.BookInvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInvTitle.Location = new System.Drawing.Point(373, 32);
            this.BookInvTitle.Name = "BookInvTitle";
            this.BookInvTitle.Size = new System.Drawing.Size(618, 55);
            this.BookInvTitle.TabIndex = 8;
            this.BookInvTitle.Text = "Search or Checkout A Book";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(1133, 656);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(300, 125);
            this.MainMenu.TabIndex = 9;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // GenreList
            // 
            this.GenreList.FormattingEnabled = true;
            this.GenreList.Items.AddRange(new object[] {
            "",
            "Fantasy",
            "Childrens",
            "Fiction",
            "SciFi",
            "Drama",
            "Romance",
            "Mystery",
            "Action"});
            this.GenreList.Location = new System.Drawing.Point(113, 504);
            this.GenreList.Name = "GenreList";
            this.GenreList.Size = new System.Drawing.Size(224, 28);
            this.GenreList.TabIndex = 10;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(604, 656);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(300, 125);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(937, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1140, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1331, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Due Date";
            // 
            // BookInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 829);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.GenreList);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.BookInvTitle);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.AuthLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BookInvTitleTxt);
            this.Controls.Add(this.BookInvAuthTxt);
            this.Controls.Add(this.InvBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "BookInv";
            this.Text = "BookInv";
            this.Load += new System.EventHandler(this.BookInv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox BookInvAuthTxt;
        private System.Windows.Forms.TextBox BookInvTitleTxt;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label BookInvTitle;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.ComboBox GenreList;
        public System.Windows.Forms.ListBox InvBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}