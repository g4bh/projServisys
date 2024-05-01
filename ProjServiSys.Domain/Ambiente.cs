using System.ComponentModel.DataAnnotations;

namespace ProjServiSys.Domain
{
    public class Ambiente
    {
        [Key] public int Id { get; set; }
        public string NomeAmbiente { get; set; }
        public IEnumerable<Equipamento> Equipamentos { get; set; }
    }
}
