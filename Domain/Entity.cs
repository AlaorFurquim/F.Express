namespace F.Express.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CreateBy { get; set; }

        public DateTime CreateOn { get; set; }

        public string EditeBy { get; set; }

        public DateTime EditOn { get; set; }
    }
}
