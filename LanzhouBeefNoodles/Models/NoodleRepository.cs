namespace LanzhouBeefNoodles.Models;

public class NoodleRepository : INoodleRepository
{
    private readonly AppDbContext _context;

    public NoodleRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Noodle> GetAllNoodles()
    {
        return _context.Noodles;
    }

    public Noodle GetNoodleById(int id)
    {
        return _context.Noodles.FirstOrDefault(n => n.Id == id);
    }
}