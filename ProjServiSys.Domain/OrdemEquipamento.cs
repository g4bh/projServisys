using System.ComponentModel.DataAnnotations;

namespace ProjServiSys.Domain
{
    public class OrdemEquipamento
    {
        public int OrdemServicoId { get; set; }
        public OrdemServico ordemServico { get; set; }
        public int EquipamentoId { get; set; }
        public Equipamento equipamento { get; set; }
    }
}
