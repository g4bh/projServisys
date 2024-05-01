using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjServiSys.Application.Dto
{
    public class OrdemEquipamentoDto
    {
        public int OrdemServicoId { get; set; }
        public OrdemServicoDto ordemServico { get; set; }
        public int EquipamentoId { get; set; }
        public EquipamentoDto equipamento { get; set; }
    }
}