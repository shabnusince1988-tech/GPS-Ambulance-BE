namespace AmbulanceAPI.Models.Entities
{
    public class TrafficSignal
    {
        public int SignalID { get; set; }
        public string SignalName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string CurrentLightMode { get; set; }
    }
}
