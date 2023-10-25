namespace NestedProsjekt.Models
{
    public class Checklist
    {
        public string? Kategorier { get; set; }
        public string? Sjekkpunkter { get; set; }
        public bool OK { get; set; }
        public bool BørSkiftes {  get; set; }
        public bool Defekt {  get; set; }
    }
}