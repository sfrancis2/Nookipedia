namespace Nookipedia
{
    internal class Fish
    {
        public int FishID { get; set; }
        public string? FishName { get; set; }
        public TimeSpan FishStart { get; set; }
        public TimeSpan FishEnd { get; set; }

        public string FishType = "Fish";
    }
}
