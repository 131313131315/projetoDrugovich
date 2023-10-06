using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Dtos.Grupo;

namespace Teste.Forms.Api
{
    public class GrupoApi : BaseApi
    {
        public static List<GrupoDto> GetAll()
        {


            List<GrupoDto> listaGrupo = new List<GrupoDto>();

            HttpResponseMessage response = GetAPI("api/Grupo");

            if (response.IsSuccessStatusCode)
            {
                listaGrupo = response.Content.ReadAsAsync<List<GrupoDto>>().Result;
            }

            return listaGrupo;
        }

        public static bool AdicionarGrupo(GrupoDto grupo)
        {

            bool retorno = false;

            HttpResponseMessage response = PostAPI("api/Grupo", grupo);

            if (response.IsSuccessStatusCode)
            {
                retorno = response.Content.ReadAsAsync<bool>().Result;
            }

            return retorno;
        }

        public static bool AlterarGrupo(GrupoDto grupo)
        {

            bool retorno = false;

            HttpResponseMessage response = PutAPI("api/Grupo", grupo);

            if (response.IsSuccessStatusCode)
            {
                retorno = response.Content.ReadAsAsync<bool>().Result;
            }

            return retorno;
        }

        public static bool DeletarGrupo(int id)
        {

            bool retorno = false;

            HttpResponseMessage response = DeleteAPI("api/Grupo/" + id);

            if (response.IsSuccessStatusCode)
            {
                retorno = response.Content.ReadAsAsync<bool>().Result;
            }

            return retorno;
        }

    }
}
