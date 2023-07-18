using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Appointments
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IRepository _repository;

        public AppointmentService(IAppointmentRepository appointmentRepository, IRepository repository)
        {
            _appointmentRepository = appointmentRepository;
            _repository = repository;
        }

        public async Task AddAsync(Appointment appointment)
        {
            try
            {
                _repository.Add(appointment);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(Appointment appointment)
        {
            try
            {

            }
            catch (global::System.Exception e)
            {

                throw new Exception(e.Message);
            }
            _repository.Delete(appointment);
            await _repository.SaveChangesAsync();
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _appointmentRepository.GetAllAsync();
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _appointmentRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Appointment appointment)
        {
            _repository.Update(appointment);
            await _repository.SaveChangesAsync();
        }
    }
}
