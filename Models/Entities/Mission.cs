namespace AmbulanceAPI.Models.Entities
{
    public class Mission
    {
        public int MissionID { get; set; }
        public string AmbulanceID { get; set; }
        public int? HospitalID { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime? EndTime { get; set; }
        public string MissionStatus { get; set; } = "ACTIVE";
    }
}
