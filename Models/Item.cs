namespace DotNetCourse.Models
{
    public class Item
    {
        public Item()
        {
            
        }

        public Item(int Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } 
    }
}