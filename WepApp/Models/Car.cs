namespace WepApp.Models
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
