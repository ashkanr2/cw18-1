namespace cw18_1.Models
{
    public class Book
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public  Genre  Genre { get; set; }
        public int GenreId { get; set; }
      public List<User> Users { get; set; }

    }
    
}
