using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjServiSys.Domain;

namespace ProjServiSys.Persistence.Contratos
{
    public interface IOrdemServicoPersist
    {
        Task<OrdemServico[]> GetAllOrdensServicoAsync(int userId, bool includeOrdemEquipamento);
        Task<OrdemServico> GetOrdemServicoByIdAsync(int userId, int OrdemServicoId, bool includeOrdemEquipamento);
        Task<OrdemServico[]> GetAllOrdensServicoByUsuarioAsync(int userId, bool includeOrdemEquipamento);
    }
}