using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProjServiSys.Application.Dto
{
    public class EquipamentoDto
    {
        public int Id { get; set; }
        public string NomeEquipamento { get; set; }
        public string SerialEquipamento { get; set; }
        public string TipoEquipamento { get; set; }
        public int AmbienteId { get; set; }
        public AmbienteDto Ambiente { get; set; }
    }
}