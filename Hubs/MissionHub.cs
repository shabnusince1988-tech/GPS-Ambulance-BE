using AmbulanceAPI.Models.DTOs;
using Microsoft.AspNetCore.SignalR;

public class MissionHub : Hub
{
    // Ambulance sends GPS update
    public async Task UpdateLocation(string ambId, double lat, double lng)
    {
        // Broadacst to everyone listening (Police/Hospitals)
        await Clients.All.SendAsync("ReceiveLocation", ambId, lat, lng);
    }

    // Ambulance sends Vitals
    public async Task BroadcastVitals(VitalsUpdateDto vitals)
    {
        await Clients.All.SendAsync("ReceiveVitals", vitals);
    }
}
