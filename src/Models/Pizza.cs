namespace ContosoPizza.Models
{
    public record Pizza
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public bool IsGlutenFree { get; init; }
    }
}