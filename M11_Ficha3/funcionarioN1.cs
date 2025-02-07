using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_Ficha3
{
    public class funcionarioN1: funcionario
    {
        public override double ParticipacaoLucro()
        {
            return base.ParticipacaoLucro() * 0.01;
        }
    }
}
