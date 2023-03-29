using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Pokemon
{
    internal class magikarp : Pokemons
    {
        public magikarp() 
        {
            Random random = new Random();
            this.name = "Magikarp";
            this.hp = random.Next(100, 200);
            this._image = Properties.Resources.magikarp;
            this.attack = random.Next(50, 100);
            this.defense = random.Next(75, 150);
        }

    }
}
