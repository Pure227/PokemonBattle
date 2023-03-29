using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Pokemon
{
    internal class budew : Pokemons
    {
        public budew()
        {
            Random random = new Random();
            this.name = "Budew";
            this.hp = random.Next(105, 402);
            this._image = Properties.Resources.budew;
            this.attack = random.Next(54, 100);
            this.defense = random.Next(7, 1500);
        }
    }
}
