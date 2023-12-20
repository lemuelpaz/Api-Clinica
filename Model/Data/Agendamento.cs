﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace API.Model.Data
{
    public class Agendamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? Horario { get; set; }
        public int? PacienteId { get; set; }
        public int? MedicoId { get; set; }
        public string? Observacao { get; set; }


        public Medico? Medico { get; set; }

        [XmlIgnore, JsonIgnore]
        public Paciente? Paciente { get; set; }

        [XmlIgnore, JsonIgnore]
        public Atendimento? Atendimento { get; set; }
    }
}
