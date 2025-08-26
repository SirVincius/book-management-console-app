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
        public DateOnly BirthDate { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }
        
        public Author(int id, string name, DateOnly birthDate, string lastName, string nationality, string biography)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            LastName = lastName;
            Nationality = nationality;
            Biography = biography;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Book management program running...");
        }
    }
}
