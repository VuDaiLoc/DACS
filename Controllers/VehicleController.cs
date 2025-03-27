using Microsoft.AspNetCore.Mvc;

public class VehicleController : Controller
{
    private readonly ApplicationDbContext _context;

    public VehicleController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string search)
    {
        var vehicles = _context.Vehicles.AsQueryable();

        if (!string.IsNullOrEmpty(search))
        {
            vehicles = vehicles.Where(v => v.LicensePlate.Contains(search));
        }

        var vehicleList = vehicles.ToList();
        return View("QuanLyXe",vehicleList);
    }

    public IActionResult DashBoard()
    {
        return View();
    }
}
