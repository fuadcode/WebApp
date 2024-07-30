namespace WepApp.Models
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
        public List<Car> Cars { get; set; }
    }
}
