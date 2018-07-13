using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GerenciadorPedidos.Models;

namespace GerenciadorPedidos.DAO
{
    public class LoginDAO
    {

        public static OPERADOR GetUsuario(string identificacao, string senha)
        {
            using (var contexto = new GerenciadorPedidosContext())
            {
                return contexto.OPERADOR.FirstOrDefault(
                    u => u.IDENTIFICACAO.Equals(identificacao) && u.SENHA.Equals(senha)
                );
            }
        }
    }
}