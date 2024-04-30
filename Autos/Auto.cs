using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    internal class Auto
    {
        private string color;
        private string alias;
        private int velocidad;

        public void Acelerar()
        {
            if (velocidad < 200) velocidad = velocidad + 5;
        }
        public void Frenar()
        {
            if (velocidad > 0) velocidad = velocidad - 5;
        }
        public void Pintar(string color)
        {
            this.color = color;
        }
        public int DevolverVelocidad()
        {
            return velocidad;
        }
        public string DevovlerColor()
        {
            return color;
        }
        public void setAlias(string alias)
        {
            this.alias = alias;
        }
        public string getAlias()
        {
            return alias;
        }
    }
}
