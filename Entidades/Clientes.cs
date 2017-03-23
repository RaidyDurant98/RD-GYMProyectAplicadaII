using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public string Direccion { get; set; }
        public string NumeroCelular { get; set; }
        public string Email { get; set; }

        public Clientes()
        {

        }

        public Clientes(int clienteId, string nombres, string sexo, DateTime fechaInscripcion, string direccion, string numeroCelular, string email)
        {
            this.ClienteId = clienteId;
            this.Nombres = nombres;
            this.Sexo = sexo;
            this.FechaInscripcion = fechaInscripcion;
            this.Direccion = direccion;
            this.NumeroCelular = numeroCelular;
            this.Email = email;
        }
    }
}
