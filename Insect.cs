namespace Nookipedia
{
    internal class Insect
    {
        public int InsectID { get; set; }
        public string? InsectName { get; set; }
        public TimeSpan InsectStart { get; set; }
        public TimeSpan InsectEnd { get; set; }
        public string? InsectType { get; set; } = "Insect";
    }
}
