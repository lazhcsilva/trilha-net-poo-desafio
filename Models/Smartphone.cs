using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_celular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebenco ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}