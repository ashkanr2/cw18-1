namespace cw18_1.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string  Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
      
        public City City { get; set; }
        public int CityId { get; set; }
       
    }
}
