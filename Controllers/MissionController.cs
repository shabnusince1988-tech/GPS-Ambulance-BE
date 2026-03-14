using AmbulanceAPI.Models.DTOs;
using AmbulanceAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

[ApiController]
[Route("api/[controller]")]
public class MissionController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    private readonly IHubContext<MissionHub> _hub;

    public MissionController(ApplicationDbContext db, IHubContext<MissionHub> hub)
    {
        _db = db;
        _hub = hub;
    }

    [HttpPost("vitals")]
    public async Task<IActionResult> UpdateVitals(VitalsUpdateDto dto)
    {
        var log = new VitalsLog
        {
            MissionID = dto.MissionID,
            HeartRate = dto.HeartRate,
            SpO2 = dto.SpO2,
            TraumaLevel = dto.TraumaLevel,
            AmbulanceLat = dto.CurrentLat,
            AmbulanceLng = dto.CurrentLng
        };

        _db.VitalsLogs.Add(log);
        await _db.SaveChangesAsync();

        // Push real-time to Hospital dashboard
        await _hub.Clients.All.SendAsync("ReceiveVitals", dto);

        return Ok(new { message = "Vitals Synced Successfully" });
    }
}
