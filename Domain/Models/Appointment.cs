using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Appointment
    {
        public global::System.Int32 Id { get; set; }
        public global::System.String NomeCliente { get; set; }
        public global::System.String CPF { get; set; }
        public global::System.String Telefone { get; set; }
        public global::System.String Email { get; set; }
        public global::System.Date Data { get; set; }
        public global::System.TimeSpan Hora { get; set; }
        public global::System.String Servico { get; set; }
        public global::System.String Observacao { get; set; }
    }
}
