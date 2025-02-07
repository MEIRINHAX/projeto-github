using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_Ficha3
{
    public class funcionarioN3 : funcionario
    {
        public override double ParticipacaoLucro()
        {
            return base.ParticipacaoLucro() * 0.03;
        }
    }
}
