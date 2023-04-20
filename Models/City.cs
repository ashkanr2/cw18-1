namespace cw18_1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Town Town { get; set; }
        public int TownId { get; set; }
    }
}
