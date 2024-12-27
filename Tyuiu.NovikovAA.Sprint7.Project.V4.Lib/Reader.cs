public class Reader
{
    public string LibraryCardNumber { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ReturnDate { get; set; }

    // Преобразует объект Reader в строку CSV
    public string ToCsv()
    {
        return $"{LibraryCardNumber},{FullName},{Address},{Phone},{IssueDate.ToString("yyyy-MM-dd")},{ReturnDate.ToString("yyyy-MM-dd")}";
    }

    // Создает объект Reader из строки CSV
    public static Reader FromCsv(string csvLine)
    {
        var values = csvLine.Split(',');
        return new Reader
        {
            LibraryCardNumber = values[0],
            FullName = values[1],
            Address = values[2],
            Phone = values[3],
            IssueDate = DateTime.Parse(values[4]),
            ReturnDate = DateTime.Parse(values[5])
        };
    }
}
