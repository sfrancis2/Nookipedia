namespace Nookipedia
{
    internal class SeaCreature
    {
        public int SeaCreatureID { get; set; }
        public string? SeaCreatureName { get; set; }
        public TimeSpan SeaCreatureStart { get; set; }
        public TimeSpan SeaCreatureEnd { get; set; }
        public string SeaCreatureType = "Sea Creature";
    }
}
