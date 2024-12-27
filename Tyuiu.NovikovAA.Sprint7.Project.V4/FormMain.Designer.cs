namespace Tyuiu.NovikovAA.Sprint7.Project.V4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearchBook = new TextBox();
            btnSearchBook = new Button();
            lstBooks = new ListBox();
            txtSearchReader = new TextBox();
            btnSearchReader = new Button();
            lstReaders = new ListBox();
            btnLoad = new Button();
            btnSave = new Button();
            txtCardNumber = new TextBox();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            dtpIssueDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            btnAddReader = new Button();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            chkNewEdition = new CheckBox();
            txtAnnotation = new TextBox();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(12, 12);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(250, 23);
            txtSearchBook.TabIndex = 0;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(268, 12);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(75, 23);
            btnSearchBook.TabIndex = 1;
            btnSearchBook.Text = "Поиск книги";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(12, 41);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(331, 199);
            lstBooks.TabIndex = 2;
            // 
            // txtSearchReader
            // 
            txtSearchReader.Location = new Point(12, 246);
            txtSearchReader.Name = "txtSearchReader";
            txtSearchReader.Size = new Size(250, 23);
            txtSearchReader.TabIndex = 3;
            // 
            // btnSearchReader
            // 
            btnSearchReader.Location = new Point(268, 246);
            btnSearchReader.Name = "btnSearchReader";
            btnSearchReader.Size = new Size(75, 23);
            btnSearchReader.TabIndex = 4;
            btnSearchReader.Text = "Поиск читателя";
            btnSearchReader.UseVisualStyleBackColor = true;
            btnSearchReader.Click += btnSearchReader_Click;
            // 
            // lstReaders
            // 
            lstReaders.FormattingEnabled = true;
            lstReaders.ItemHeight = 15;
            lstReaders.Location = new Point(12, 275);
            lstReaders.Name = "lstReaders";
            lstReaders.Size = new Size(331, 199);
            lstReaders.TabIndex = 5;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(93, 480);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(12, 520);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.PlaceholderText = "Номер карты";
            txtCardNumber.Size = new Size(250, 23);
            txtCardNumber.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 549);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Полное имя";
            txtFullName.Size = new Size(250, 23);
            txtFullName.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 578);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Адрес";
            txtAddress.Size = new Size(250, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 607);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Телефон";
            txtPhone.Size = new Size(250, 23);
            txtPhone.TabIndex = 11;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(12, 636);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(250, 23);
            dtpIssueDate.TabIndex = 12;
            dtpIssueDate.Value = new DateTime(2024, 12, 26, 0, 0, 0, 0);
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(12, 665);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 23);
            dtpReturnDate.TabIndex = 13;
            dtpReturnDate.Value = new DateTime(2024, 12, 26, 0, 0, 0, 0);
            // 
            // btnAddReader
            // 
            btnAddReader.Location = new Point(268, 520);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(75, 23);
            btnAddReader.TabIndex = 14;
            btnAddReader.Text = "Добавить читателя";
            btnAddReader.UseVisualStyleBackColor = true;
            btnAddReader.Click += btnAddReader_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 694);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Автор";
            txtAuthor.Size = new Size(250, 23);
            txtAuthor.TabIndex = 15;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 723);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Название книги";
            txtTitle.Size = new Size(250, 23);
            txtTitle.TabIndex = 16;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 752);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Год издания";
            txtYear.Size = new Size(250, 23);
            txtYear.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 781);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Цена";
            txtPrice.Size = new Size(250, 23);
            txtPrice.TabIndex = 18;
            // 
            // chkNewEdition
            // 
            chkNewEdition.Location = new Point(12, 810);
            chkNewEdition.Name = "chkNewEdition";
            chkNewEdition.Size = new Size(250, 24);
            chkNewEdition.TabIndex = 19;
            chkNewEdition.Text = "Новый выпуск";
            chkNewEdition.UseVisualStyleBackColor = true;
            // 
            // txtAnnotation
            // 
            txtAnnotation.Location = new Point(12, 840);
            txtAnnotation.Multiline = true;
            txtAnnotation.Name = "txtAnnotation";
            txtAnnotation.PlaceholderText = "Аннотация";
            txtAnnotation.Size = new Size(250, 60);
            txtAnnotation.TabIndex = 20;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(268, 694);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 21;
            btnAddBook.Text = "Добавить книгу";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(366, 900);
            Controls.Add(btnAddBook);
            Controls.Add(txtAnnotation);
            Controls.Add(chkNewEdition);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(btnAddReader);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpIssueDate);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(txtCardNumber);
            Controls.Add(lstReaders);
            Controls.Add(btnSearchReader);
            Controls.Add(txtSearchReader);
            Controls.Add(lstBooks);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearchBook);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Name = "FormMain";
            Text = "Библиотека";
            this.StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtSearchReader;
        private System.Windows.Forms.Button btnSearchReader;
        private System.Windows.Forms.ListBox lstReaders;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.Button btnFindReader;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkNewEdition;
        private System.Windows.Forms.TextBox txtAnnotation;
        private System.Windows.Forms.Button btnAddBook;
    }
}
