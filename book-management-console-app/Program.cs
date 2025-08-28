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

        public string getAuthorName() => Author.Name;

        public string getAuthorLastName() => Author.LastName;

        public string getAuthorCompleteName() => $"{Author.Name} {Author.LastName}";

        public override string ToString()
        {
            return $"{Title}, {Author.Name} {Author.LastName}, {Genre}, {PublicationDate.ToString("dd MM yyyy")}, {ISBN}, {Publisher}, {NumberOfPages} pages";
        }

    }

    class Library
    {
        public List<Book> ListOfBook { get; set; } = new List<Book>();
        public List<Author> ListOfAuthor { get; set; } = new List<Author>();

    }
    class Program
    {

        public static void printMenu()
        {
            Console.WriteLine("-- BOOK MANAGEMENT SYSTEM --\n");
            Console.WriteLine("1. Visualize the list of all books");
            Console.WriteLine("2. Search books by genre");
            Console.WriteLine("3. Search book by author");
            Console.WriteLine("4. Search books by keyword");
        }

        public static int validateMenuChoice()
        {
            int choice = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice) && choice >=1 && choice <= 4)
                {
                    Console.WriteLine($"Choice = {choice}");
                    return choice;
                }
                else
                {
                    Console.WriteLine("Choice is invalid, please enter a vlid choice");
                }
            }
        }
        public static void Main(string[] args)
        {
            printMenu();
            validateMenuChoice();

            //Generating multiple author
            Author king = new Author(1, "Stephen", "King", new DateOnly(1947, 9, 21), "American", "Master of horror and suspense.");
            Author rowling = new Author(2, "J.K.", "Rowling", new DateOnly(1965, 7, 31), "British", "Author of the Harry Potter series.");
            Author orwell = new Author(3, "George", "Orwell", new DateOnly(1903, 6, 25), "British", "Known for dystopian and political works.");
            Author tolkien = new Author(4, "J.R.R.", "Tolkien", new DateOnly(1892, 1, 3), "British", "Author of The Lord of the Rings.");
            Author austen = new Author(5, "Jane", "Austen", new DateOnly(1775, 12, 16), "British", "Famous for novels about society and romance.");
            Author shelley = new Author(6, "Mary", "Shelley", new DateOnly(1797, 8, 30), "British", "Author of Frankenstein.");
            Author hawking = new Author(7, "Stephen", "Hawking", new DateOnly(1942, 1, 8), "British", "Renowned physicist and cosmologist.");
            Author frank = new Author(8, "Anne", "Frank", new DateOnly(1929, 6, 12), "German-Dutch", "Jewish diarist during WWII.");
            Author hemingway = new Author(9, "Ernest", "Hemingway", new DateOnly(1899, 7, 21), "American", "American novelist and Nobel Prize winner.");
            Author dostoevsky = new Author(10, "Fyodor", "Dostoevsky", new DateOnly(1821, 11, 11), "Russian", "Philosophical novelist.");

            //Library initialization
            Library library = new Library();

            //Generating list of books for a library
            library.ListOfBook = new List<Book>
            {
                new Book("The Shining", king, Genre.Horror, new DateOnly(1977, 1, 28), 9780385121675, "Doubleday", 447),
                new Book("It", king, Genre.Horror, new DateOnly(1986, 9, 15), 9780670813025, "Viking", 1138),
                new Book("Misery", king, Genre.Thriller, new DateOnly(1987, 6, 8), 9780670813643, "Viking", 320),
                new Book("The Green Mile", king, Genre.Thriller, new DateOnly(1996, 3, 28), 9780452278905, "Signet", 400),

                new Book("Harry Potter and the Philosopher's Stone", rowling, Genre.Fantasy, new DateOnly(1997, 6, 26), 9780747532699, "Bloomsbury", 223),
                new Book("Harry Potter and the Chamber of Secrets", rowling, Genre.Fantasy, new DateOnly(1998, 7, 2), 9780747538493, "Bloomsbury", 251),
                new Book("Harry Potter and the Prisoner of Azkaban", rowling, Genre.Fantasy, new DateOnly(1999, 7, 8), 9780747542155, "Bloomsbury", 317),

                new Book("1984", orwell, Genre.ScienceFiction, new DateOnly(1949, 6, 8), 9780451524935, "Secker & Warburg", 328),
                new Book("Animal Farm", orwell, Genre.Historical, new DateOnly(1945, 8, 17), 9780451526342, "Secker & Warburg", 112),

                new Book("The Lord of the Rings: The Fellowship of the Ring", tolkien, Genre.Fantasy, new DateOnly(1954, 7, 29), 9780261103573, "Allen & Unwin", 423),
                new Book("The Hobbit", tolkien, Genre.Fantasy, new DateOnly(1937, 9, 21), 9780048231887, "Allen & Unwin", 310),

                new Book("Pride and Prejudice", austen, Genre.Romance, new DateOnly(1813, 1, 28), 9781503290563, "T. Egerton", 279),

                new Book("Frankenstein", shelley, Genre.Horror, new DateOnly(1818, 1, 1), 9780486282114, "Lackington, Hughes, Harding, Mavor & Jones", 280),

                new Book("A Brief History of Time", hawking, Genre.History, new DateOnly(1988, 3, 1), 9780553380163, "Bantam Books", 256),

                new Book("The Diary of a Young Girl", frank, Genre.Biography, new DateOnly(1947, 6, 25), 9780553296983, "Contact Publishing", 283),

                new Book("The Old Man and the Sea", hemingway, Genre.Historical, new DateOnly(1952, 9, 1), 9780684801223, "Charles Scribner's Sons", 127),

                new Book("Crime and Punishment", dostoevsky, Genre.Historical, new DateOnly(1866, 1, 1), 9780140449136, "The Russian Messenger", 671),

                new Book("War and Peace", dostoevsky, Genre.Historical, new DateOnly(1869, 1, 1), 9780199232765, "The Russian Messenger", 1225),

                new Book("Emma", austen, Genre.Romance, new DateOnly(1815, 12, 23), 9781503280298, "John Murray", 474),
            };
        }
    }
}
