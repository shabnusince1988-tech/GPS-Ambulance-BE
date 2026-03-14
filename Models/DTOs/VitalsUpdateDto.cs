namespace AmbulanceAPI.Models.DTOs
{
    public class VitalsUpdateDto
    {
        public int MissionID { get; set; }
        public int HeartRate { get; set; }
        public int SpO2 { get; set; }
        public string TraumaLevel { get; set; }
        public decimal CurrentLat { get; set; }
        public decimal CurrentLng { get; set; }
    }
}
