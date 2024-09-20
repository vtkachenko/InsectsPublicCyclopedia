namespace InsectsPublicCyclopedia.Data
{
    public class Insect
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } // Binary photo
        public string Name { get; set; }
        public string Description { get; set; }
    }

}
