using System.ComponentModel.DataAnnotations;

namespace ProjServiSys.Domain
{
    public class Equipamento
    {
        [Key] public int Id { get; set; }
        public string NomeEquipamento { get; set; }
        public string SerialEquipamento { get; set; }
        public string TipoEquipamento { get; set; }
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }

        public IEnumerable<OrdemEquipamento> OrdemEquipamentos { get; set; }
    }
}
