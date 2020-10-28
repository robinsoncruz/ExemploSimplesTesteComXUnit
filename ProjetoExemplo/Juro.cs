using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExemplo
{
    public class Juro
    {
        public double capital { get; set; }
        public double juro { get; set; }
        public double resultado { get; private set; }
        public int meses { get; set; }
        public void CalcularJuroComposto()
        {
            resultado = capital * Math.Pow((1 + juro / 100), meses);
        }
        public void CalcularJuroSimples()
        {
            resultado = capital * (1 + (meses * juro)/100);
        }
    }
}
