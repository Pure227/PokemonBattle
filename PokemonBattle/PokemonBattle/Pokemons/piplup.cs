using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Pokemon
{
    internal class piplup : Pokemons
    {
        public piplup()
        {
            Random random = new Random();
            this.name = "Piplup";
            this.hp = random.Next(100, 300);
            this._image = Properties.Resources.piplup;
            this.attack = random.Next(500, 1000);
            this.defense = random.Next(750, 1500);
        }
    }
}
