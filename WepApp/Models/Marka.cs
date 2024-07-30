namespace WepApp.Models
{
    public class Marka : BaseEntity
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; }
    }
}
