using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Pokemon
{
    internal class rayquaza : Pokemons
    {
        public rayquaza()
        {
            Random random = new Random();
            this.name = "Rayquaza";
            this.hp = random.Next(10000, 200000);
            this._image = Properties.Resources.rayquaza;
            this.attack = random.Next(500, 100000);
            this.defense = random.Next(765, 115000);
        }
    }
}
