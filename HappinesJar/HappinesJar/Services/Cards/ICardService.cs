using HappinesJar.Jar.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HappinesJar.Services.Cards
{
    public interface ICardService
    {
        [Get("/jar/all/CODE")]
        Task<JarDTO> GetJarAsync();
    }
}
