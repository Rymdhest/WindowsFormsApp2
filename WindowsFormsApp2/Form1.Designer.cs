namespace WindowsFormsApp2
{
    partial class Form1
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
            this.SuggestBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Borrowed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newBorrowed = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuggestBTN
            // 
            this.SuggestBTN.Location = new System.Drawing.Point(89, 15);
            this.SuggestBTN.Name = "SuggestBTN";
            this.SuggestBTN.Size = new System.Drawing.Size(146, 33);
            this.SuggestBTN.TabIndex = 0;
            this.SuggestBTN.Text = "Suggest Book";
            this.SuggestBTN.UseVisualStyleBackColor = true;
            this.SuggestBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.Genre,
            this.Borrowed});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(405, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 380);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 100;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 100;
            // 
            // Borrowed
            // 
            this.Borrowed.Text = "Borrowed";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SuggestBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newBorrowed);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.newGenre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.newAuthor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.newName);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(27, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 161);
            this.panel2.TabIndex = 4;
            // 
            // newBorrowed
            // 
            this.newBorrowed.AutoSize = true;
            this.newBorrowed.Location = new System.Drawing.Point(9, 98);
            this.newBorrowed.Name = "newBorrowed";
            this.newBorrowed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newBorrowed.Size = new System.Drawing.Size(71, 17);
            this.newBorrowed.TabIndex = 11;
            this.newBorrowed.Text = "Borrowed";
            this.newBorrowed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // newGenre
            // 
            this.newGenre.Location = new System.Drawing.Point(66, 69);
            this.newGenre.Name = "newGenre";
            this.newGenre.Size = new System.Drawing.Size(164, 20);
            this.newGenre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // newAuthor
            // 
            this.newAuthor.Location = new System.Drawing.Point(66, 43);
            this.newAuthor.Name = "newAuthor";
            this.newAuthor.Size = new System.Drawing.Size(164, 20);
            this.newAuthor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(66, 17);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(164, 20);
            this.newName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SuggestBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Borrowed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newAuthor;
        private System.Windows.Forms.CheckBox newBorrowed;
    }
}

