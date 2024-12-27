using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.NovikovAA.Sprint7.Project.V4.Lib;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.NovikovAA.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        private DataService _dataService;

        public FormMain()
        {
            InitializeComponent();
            _dataService = new DataService();
            _dataService.LoadData("books.csv", "readers.csv"); // Adjust file paths as needed
            RefreshData();
        }

        // Обработчик для загрузки данных
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _dataService.LoadData("books.csv", "readers.csv");  // Замените пути на актуальные
                MessageBox.Show("Данные успешно загружены!");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        // Обработчик для сохранения данных
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dataService.SaveData("books.csv", "readers.csv");  // Замените пути на актуальные
                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }


        // Событие для добавления книги
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                !int.TryParse(txtYear.Text, out int year) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Пожалуйста, убедитесь, что все поля заполнены правильно.");
                return;
            }

            var book = new Book
            {
                Author = txtAuthor.Text,
                Title = txtTitle.Text,
                Year = year,
                Price = price,
                IsNewEdition = chkNewEdition.Checked,
                Annotation = txtAnnotation.Text
            };

            _dataService.AddBook(book);
            RefreshData();
        }

        // Событие для добавления читателя
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Пожалуйста, убедитесь, что все поля заполнены правильно.");
                return;
            }

            var reader = new Reader
            {
                LibraryCardNumber = txtCardNumber.Text,
                FullName = txtFullName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                IssueDate = dtpIssueDate.Value,
                ReturnDate = dtpReturnDate.Value
            };

            _dataService.AddReader(reader);
            RefreshData();
        }

        private void RefreshData()
        {
            lstBooks.Items.Clear();
            foreach (var book in _dataService.Books)
            {
                lstBooks.Items.Add($"{book.Title} ({book.Author})");
            }

            lstReaders.Items.Clear();
            foreach (var reader in _dataService.Readers)
            {
                lstReaders.Items.Add($"{reader.FullName} ({reader.LibraryCardNumber})");
            }
        }


        // Событие для поиска книги по точному названию
        private void btnFindBook_Click(object sender, EventArgs e)
        {
            var title = txtSearchBook.Text;
            var book = _dataService.FindBookByTitle(title);
            if (book != null)
            {
                MessageBox.Show($"Книга найдена: {book.Title}, автор: {book.Author}");
            }
            else
            {
                MessageBox.Show("Книга не найдена");
            }
        }

        // Событие для поиска читателя по номеру билета
        private void btnFindReader_Click(object sender, EventArgs e)
        {
            var cardNumber = txtSearchReader.Text;
            var reader = _dataService.FindReaderByCardNumber(cardNumber);
            if (reader != null)
            {
                MessageBox.Show($"Читатель найден: {reader.FullName}, номер билета: {reader.LibraryCardNumber}");
            }
            else
            {
                MessageBox.Show("Читатель не найден");
            }
        }

        // Событие для поиска книг по частичному совпадению
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBook.Text.ToLower();
            var filteredBooks = _dataService.SearchBooks(searchTerm); // Используем метод поиска с частичным совпадением

            lstBooks.Items.Clear();
            foreach (var book in filteredBooks)
            {
                lstBooks.Items.Add(book.Title); // Отображаем только название книги
            }
        }

        // Событие для поиска читателей по частичному совпадению
        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchReader.Text.ToLower();
            var filteredReaders = _dataService.SearchReaders(searchTerm); // Используем метод поиска с частичным совпадением

            lstReaders.Items.Clear();
            foreach (var reader in filteredReaders)
            {
                lstReaders.Items.Add(reader.FullName); // Отображаем только ФИО читателя
            }
        }
    }
}
