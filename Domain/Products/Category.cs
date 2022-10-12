namespace F.Express.Domain.Products
{
    public class Category : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Active { get; set; } = true;

    }
}
