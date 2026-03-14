using AmbulanceAPI.Services.Interfaces;

public class GeofenceService : IGeofenceService
{
    public bool IsWithinRange(decimal lat1, decimal lng1, decimal lat2, decimal lng2, double rangeInMeters)
    {
        var d1 = (double)lat1 * (Math.PI / 180.0);
        var num1 = (double)lng1 * (Math.PI / 180.0);
        var d2 = (double)lat2 * (Math.PI / 180.0);
        var num2 = (double)lng2 * (Math.PI / 180.0) - num1;
        var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

        double distance = 6371000.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        return distance <= rangeInMeters;
    }
}
