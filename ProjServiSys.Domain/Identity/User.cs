using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProjServiSys.Domain.Enum;
using ProjServiSys.Domain.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProjServiSys.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public bool InativaUsuario { get; set; } = false;
        public DateTime DataAlteracaoInatividade { get; set; } = DateTime.Now;
        public CargoEnum Cargo { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}