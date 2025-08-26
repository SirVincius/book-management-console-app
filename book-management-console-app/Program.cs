namespace BookManagementConsoleApp
{
    enum Genre
    {
        Thriller,
        Fantasy,
        ScienceFiction,
        Horror,
        Romance,
        Historical,
        Biography,
        History,
        Encyclopedia,

    }

    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }
        
        public Author(int id, string name, string lastName, DateOnly birthDate, string nationality, string biography)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            LastName = lastName;
            Nationality = nationality;
            Biography = biography;
        }
    }

    class Book
    {


        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public DateOnly PublicationDate { get; set; }
        public long ISBN { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, Author author, Genre genre, DateOnly publicationDate, long iSBN, string publisher, int numberOfPages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            PublicationDate = publicationDate;
            ISBN = iSBN;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Book management program running...");

            Author author = new Author(1, "Vincent", "Brunelle", new DateOnly(1985, 01, 28), "Canadian", "Well known horror author");
            Console.WriteLine(author.BirthDate);
        }
    }
}
