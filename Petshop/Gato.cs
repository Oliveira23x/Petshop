using System;


using System.Collections.Generic;


using System.Linq;


using System.Text;


using System.Threading.Tasks;

namespace Petshop


{


    public class Gato : Animal


    {
        public Gato(string nome, int idade) : base(nome, idade) { }


        public override void Atender()

        {

            Console.WriteLine($"Atendendo {nome} está miando muito!!!");
        }
    }
}

