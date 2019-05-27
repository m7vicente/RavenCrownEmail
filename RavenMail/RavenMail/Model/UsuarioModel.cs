using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenMail.Model
{
    public class UsuarioModel
    {

        public int id_usuario { get; set; }

        public String nome_usuario { get; set; }

        public String email_usuario { get; set; }

        public String cpf_cnpj { get; set; }

        public String rg { get; set; }

        public String telefone_usuario { get; set; }

        public String senha { get; set; }

        public Boolean prestador { get; set; }

        public char sexo { get; set; }

        public String estado_civil { get; set; }

        public int id_endereco { get; set; }

        public DateTime data_nascimento { get; set; }

    }
}