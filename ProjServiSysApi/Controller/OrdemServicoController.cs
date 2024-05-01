using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjServiSys.Application.Contratos;
using ProjServiSys.Application.Dto;
using ProjServiSysApi.Extensions;

namespace ProjServiSysApi.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemServicoController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IOrdemServicoService _osIService;

        public OrdemServicoController(IOrdemServicoService osIService, IAccountService accountService)
        {
            _osIService = osIService;
            _accountService = accountService;
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<OrdemServicoDto[]>> GetOrdemServico()
        {
            try
            {
                var ordensServico = await _osIService.GetAllOrdensServicoAsync(User.GetUserId(), true);
                if (ordensServico == null) return NoContent();

                return Ok(ordensServico);

            } catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar burcar ordens. Erro: {ex.Message}");
            }
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdemServicoDto>> GetOrdemServicoById(int id)
        {
            try
            {
                var ordemServico = await _osIService.GetOrdemServicoByIdAsync(User.GetUserId(), id, true);
                if (ordemServico == null) return NoContent();

                return Ok(ordemServico);

            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar buscar ordem. Erro: {ex.Message}");
            }
        }

        [HttpGet("usuario/{idUsuario}")]
        public async Task<ActionResult<OrdemServicoDto>> GetOrdemServicoByUsuario()
        {
            try
            {
                var ordemServico = await _osIService.GetAllOrdensServicoByUsuarioAsync(User.GetUserId(), true);
                if (ordemServico == null) return NoContent();

                return Ok(ordemServico);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar buscar ordem. Erro: {ex.Message}");
            }
            
        }


        [HttpPost]
        public async Task<ActionResult<OrdemServicoDto>> PostOrdemServico(OrdemServicoDto model)
        {
            try
            {
                var ordemServico = await _osIService.AddOrdensServico(User.GetUserId(), model);
                if (ordemServico == null) return NoContent();

                return Ok(ordemServico);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar criar ordem. Erro: {ex.Message}");
            }
        }


        [HttpPatch("{id}")]
        public async Task<ActionResult<OrdemServicoDto>> PutOrdemServico(int id, OrdemServicoDto model)
        {
            try
            {
                var ordemServico = await _osIService.UpdateOrdemServico(User.GetUserId(), id, model);
                if (ordemServico == null) return NoContent();

                return Ok(ordemServico);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar alterar ordem. Erro: {ex.Message}");
            }
        }


        [HttpPatch("Aprovado/{id}")]
        public async Task<ActionResult<OrdemServicoDto>> PatchAprovadoOrdemServico(int id)
        {
            try
            {
                var ordemServico = await _osIService.UpdateAprovadoOrdemServico(User.GetUserId(),id);
                if (ordemServico == null) return NoContent();

                return Ok(ordemServico);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar alterar ordem. Erro: {ex.Message}");
            }
        }

         [HttpPatch("Rejeitado/{id}")]
        public async Task<ActionResult<OrdemServicoDto>> PatchRejeitadoOrdemServico(int id)
        {
            try
            {
                var ordemServico = await _osIService.UpdateRejeitadaOrdemServico(User.GetUserId(),id);
                if (ordemServico == null) return NoContent();

                return Ok(ordemServico);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar alterar ordem. Erro: {ex.Message}");
            }
        }
    }
}