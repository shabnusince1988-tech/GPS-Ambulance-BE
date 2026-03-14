namespace AmbulanceAPI.Models.Entities
{
    public class VitalsLog
    {
        public long LogID { get; set; }
        public int MissionID { get; set; }
        public int HeartRate { get; set; }
        public int SpO2 { get; set; }
        public string TraumaLevel { get; set; }
        public DateTime LogTime { get; set; } = DateTime.Now;
        public decimal AmbulanceLat { get; set; }
        public decimal AmbulanceLng { get; set; }
    }
}
