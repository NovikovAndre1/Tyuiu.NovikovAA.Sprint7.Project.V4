using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.NovikovAA.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public List<Book> Books { get; private set; }
        public List<Reader> Readers { get; private set; }

        public DataService()
        {
            Books = new List<Book>();
            Readers = new List<Reader>();
        }

        // Метод для загрузки данных из CSV
        public void LoadData(string booksFilePath, string readersFilePath)
        {
            Books.Clear();
            Readers.Clear();

            if (File.Exists(booksFilePath))
            {
                var bookLines = File.ReadAllLines(booksFilePath);
                foreach (var line in bookLines.Skip(1)) // Пропускаем заголовок
                {
                    var book = Book.FromCsv(line);
                    if (book != null)
                        Books.Add(book);
                }
            }

            if (File.Exists(readersFilePath))
            {
                var readerLines = File.ReadAllLines(readersFilePath);
                foreach (var line in readerLines.Skip(1)) // Пропускаем заголовок
                {
                    var reader = Reader.FromCsv(line);
                    if (reader != null)
                        Readers.Add(reader);
                }
            }
        }

        // Метод для сохранения данных в CSV
        public void SaveData(string booksFilePath, string readersFilePath)
        {
            var bookLines = new List<string> { "Author,Title,Year,Price,IsNewEdition,Annotation" };
            bookLines.AddRange(Books.Select(b => b.ToCsv()));

            var readerLines = new List<string> { "LibraryCardNumber,FullName,Address,Phone,IssueDate,ReturnDate" };
            readerLines.AddRange(Readers.Select(r => r.ToCsv()));

            File.WriteAllLines(booksFilePath, bookLines);
            File.WriteAllLines(readersFilePath, readerLines);
        }

        // Добавление книги
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Добавление читателя
        public void AddReader(Reader reader)
        {
            Readers.Add(reader);
        }

        // Поиск книги по названию
        public Book FindBookByTitle(string title)
        {
            return Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // Поиск читателя по номеру билета
        public Reader FindReaderByCardNumber(string cardNumber)
        {
            return Readers.FirstOrDefault(r => r.LibraryCardNumber.Equals(cardNumber, StringComparison.OrdinalIgnoreCase));
        }

        // Поиск книг по частичному совпадению
        public List<Book> SearchBooks(string searchTerm)
        {
            return Books.Where(b => b.Title.ToLower().Contains(searchTerm) || b.Author.ToLower().Contains(searchTerm)).ToList();
        }

        // Поиск читателей по частичному совпадению
        public List<Reader> SearchReaders(string searchTerm)
        {
            return Readers.Where(r => r.FullName.ToLower().Contains(searchTerm)).ToList();
        }
    }
}
