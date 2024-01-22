using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5.Rpg.Models
{
    public class Dano: Personagem
    {
        public int DanoBase { get; set; }

        public Dano(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }

        public void CalcularDano()
        {
            Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
        }
        
    }
}