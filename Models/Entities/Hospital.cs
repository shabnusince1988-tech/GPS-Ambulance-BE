namespace AmbulanceAPI.Models.Entities
{
    public class Hospital
    {
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Specialty { get; set; }
        public int TotalERBeds { get; set; }
        public int AvailableBeds { get; set; }
    }
}
