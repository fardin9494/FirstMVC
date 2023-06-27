namespace AtriyaMVC.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public Services(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}