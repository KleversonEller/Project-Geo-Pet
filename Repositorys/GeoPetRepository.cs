using project_geopet.Models;
using project_geopet.Data;

namespace project_geopet.Repository;

public class GeoPetRepository
{
    private readonly GeoPetContext _context;

    public GeoPetRepository(GeoPetContext context)
    {
        _context = context;
    }

    public void CreatedCaringPerson(CaringPerson request)
    {
        _context.CaringPersons.Add(request);
        _context.SaveChanges();
    }
}