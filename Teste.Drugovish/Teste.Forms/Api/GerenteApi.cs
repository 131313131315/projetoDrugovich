using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Entities;


namespace Teste.Forms.Api
{
    public class GerenteApi : BaseApi
    {
        public static Gerente RealizarLogin(string nome)
        {
            Gerente gerente = new Gerente();

            HttpResponseMessage response = GetAPI("api/Gerente/entrar?nome=" + nome);

            if (response.IsSuccessStatusCode)
            {
                gerente = response.Content.ReadAsAsync<Gerente>().Result;
            }

            return gerente;
        }
    }
}
