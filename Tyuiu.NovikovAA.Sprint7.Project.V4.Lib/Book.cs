public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public bool IsNewEdition { get; set; }
    public string Annotation { get; set; }

    // Преобразует объект Book в строку CSV
    public string ToCsv()
    {
        return $"{Author},{Title},{Year},{Price},{IsNewEdition},{Annotation}";
    }

    // Создает объект Book из строки CSV
    public static Book FromCsv(string csvLine)
    {
        var values = csvLine.Split(',');
        return new Book
        {
            Author = values[0],
            Title = values[1],
            Year = int.Parse(values[2]),
            Price = decimal.Parse(values[3]),
            IsNewEdition = bool.Parse(values[4]),
            Annotation = values[5]
        };
    }
}
