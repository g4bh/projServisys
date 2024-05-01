using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjServiSys.Persistence.Contratos;
using ProjServiSys.Domain;

namespace ProjServiSys.Persistence
{
    public class OrdemServicoPersist : IOrdemServicoPersist
    {
        private readonly DbServiSysApiContext _context;

        public OrdemServicoPersist(DbServiSysApiContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<OrdemServico[]> GetAllOrdensServicoAsync(int userId,bool includeOrdemEquipamento = false)
        {
            IQueryable<OrdemServico> query = _context.OrdensServico.AsNoTracking()
                .Include(os => os.Lancamentos);

            if (includeOrdemEquipamento)
            {
                query = query.Include(os => os.OrdemEquipamentos);
            }

            query = query.Where(os => os.UserId == userId).OrderBy(os => os.Id);

            return await query.ToArrayAsync();
        }

        public async Task<OrdemServico[]> GetAllOrdensServicoByUsuarioAsync(int userId, bool includeOrdemEquipamento = false)
        {
            IQueryable<OrdemServico> query = _context.OrdensServico.AsNoTracking()
                .Include(os => os.Lancamentos);

            if (includeOrdemEquipamento)
            {
                query = query.Include(os => os.OrdemEquipamentos);
            }

            query = query.Where(os => os.UserId == userId).OrderBy(os => os.Id);

            return await query.ToArrayAsync();
        }

        public async Task<OrdemServico> GetOrdemServicoByIdAsync(int userId, int OrdemServicoId, bool includeOrdemEquipamento = false)
        {
            IQueryable<OrdemServico> query = _context.OrdensServico.AsNoTracking()
                .Include(os => os.Lancamentos);

            if (includeOrdemEquipamento)
            {
                query = query.Include(os => os.OrdemEquipamentos);
            }

            query = query.Where(os => os.Id == OrdemServicoId && os.UserId == userId);

            return await query.FirstOrDefaultAsync();
        }
    }
}