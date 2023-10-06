using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Entities;

namespace Teste.Forms.Api
{

    public class ClienteApi : BaseApi
    {
        public static List<ClienteDto> GetAll()
        {
            

            List<ClienteDto> listaClientes = new List<ClienteDto>();

            HttpResponseMessage response = GetAPI("api/Cliente");

            if (response.IsSuccessStatusCode)
            {
                listaClientes = response.Content.ReadAsAsync<List<ClienteDto>>().Result;
            }

            return listaClientes;
        }


        public static bool AdicionarCliente(ClienteDto cliente)
        {

            bool retorno = false;

            HttpResponseMessage response = PostAPI("api/Cliente", cliente);

            if (response.IsSuccessStatusCode)
            {
                retorno = response.Content.ReadAsAsync<bool>().Result;
            }

            return retorno;
        }

        public static bool AlterarCliente(ClienteDto cliente)
        {

            bool retorno = false;

            HttpResponseMessage response = PutAPI("api/Cliente", cliente);

            if (response.IsSuccessStatusCode)
            {
                retorno = response.Content.ReadAsAsync<bool>().Result;
            }

            return retorno;
        }

        public static bool DeletarCliente(int id)
        {

            bool retorno = false;

            HttpResponseMessage response = DeleteAPI("api/Cliente/" + id);

            if (response.IsSuccessStatusCode)
            {
                retorno = response.Content.ReadAsAsync<bool>().Result;
            }

            return retorno;
        }
    }



}

