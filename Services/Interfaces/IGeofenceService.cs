namespace AmbulanceAPI.Services.Interfaces
{
    public interface IGeofenceService
    {
        bool IsWithinRange(decimal lat1, decimal lng1, decimal lat2, decimal lng2, double rangeInMeters);
    }
}
