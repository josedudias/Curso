using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Models
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Combustivel { get; set; }
        public int Velocidade { get; set; }

        public Carro()
        {

        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            if (Velocidade > 0)
            {
                Velocidade -= 10;
            }
            else
            {
                Velocidade = 0;
            }
        }
    }
}
