namespace Nookipedia
{
    internal class SeaCreatureMuseum
    {
        public int SeaCreatureID { get; set; }
        public string? SeaCreatureName { get; set; }
        public string? SeaCreatureLocation { get; set; }
        public DateTime? SeaCreatureDate { get; set; }

        public string? SeaCreatureType { get; set; } = "SeaCreature";
    }
}
