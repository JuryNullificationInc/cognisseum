namespace webapi.DTOs
{
    public class ElementExtraDto : ElementDto
    {
        public long STPPhase { get; set; }

        public long CrystalConfig { get; set; }

        public long[] Classifications { get; set; }

        public ElementDiscoveryDto DiscoveryDetails { get; set; }
    }
}
