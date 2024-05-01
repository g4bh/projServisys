using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjServiSys.Application.Dto;

namespace ProjServiSys.Application.Contratos
{
    public interface IOrdemServicoService
    {
        Task<OrdemServicoDto> AddOrdensServico(int userId,OrdemServicoDto model);
        Task<OrdemServicoDto> UpdateOrdemServico(int userId,int osId, OrdemServicoDto model);
        Task<OrdemServicoDto> UpdateAprovadoOrdemServico(int userId, int osId);
        Task<OrdemServicoDto> UpdateRejeitadaOrdemServico(int userId, int osId);



        Task<OrdemServicoDto[]> GetAllOrdensServicoAsync(int userId, bool includeOrdemEquipamento);
        Task<OrdemServicoDto> GetOrdemServicoByIdAsync(int userId, int OrdemServicoId, bool includeOrdemEquipamento);
        Task<OrdemServicoDto[]> GetAllOrdensServicoByUsuarioAsync(int userId, bool includeOrdemEquipamento);
    }
}