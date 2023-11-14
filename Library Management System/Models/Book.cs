namespace Library_Management_System.Models
{
    public class Book
    {
        public Book()
        {
            // Initialize non-nullable properties in the constructor
            Author = ""; // You can use an empty string or another default value
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
