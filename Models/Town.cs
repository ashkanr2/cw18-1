namespace cw18_1.Models
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<City> Cities { get; set; }

    }
}
