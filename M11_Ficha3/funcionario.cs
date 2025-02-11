using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_Ficha3
{
    public class funcionario
    {
        public funcionario()
        {

        }

        public string nome;

        public string NomeP
        {
            get { return nome; }
            set { nome = value; }
        }

        public int idade;

        public int IdadeP
        {
            get { return idade; }
            set { idade = value; }
        }

        public int telefone;

        public int TelefoneP
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string tipofunc;

        public string TipofuncP
        {
            get { return tipofunc; }
            set { tipofunc = value; }
        }

        public double valor;

        public virtual double ParticipacaoLucro()
        {
            return 1200;
        }
    }
}
