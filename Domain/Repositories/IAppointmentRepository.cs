﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IAppointmentRepository
    {

        Task<Appointment> GetByIdAsync(int id);
        Task<List<Appointment>> GetAllAsync();
    }
}
