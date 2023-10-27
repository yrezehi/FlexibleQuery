namespace Experimental.Models
{
    public class Dummy
    {
        public string Field { get; set; } = "Dummy";
        public string Mashed { get; set; } = "Yet Dummy";
        public int Level { get; set; } = 12;
        public DateTime When { get; set; } = DateTime.Now.AddDays(1);
    }
}
