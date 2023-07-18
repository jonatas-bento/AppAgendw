using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _context;
        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Appointment> GetByIdAsync(int id)
        {
            IQueryable<Appointment> query = _context.Appointments;
            query = query.AsNoTracking().OrderBy(a => a.Id).Where(a => a.Id == id);
            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<Appointment>> GetAllAsync()
        {
            IQueryable<Appointment> query = _context.Appointments;
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return await query.ToListAsync();
        }
    }
}
