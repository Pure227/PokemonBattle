using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Pokemon
{
    internal class starly : Pokemons
    {
        public starly()
        {
            Random random = new Random();
            this.name = "Starly";
            this.hp = random.Next(1050, 3222);
            this._image = Properties.Resources.starly;
            this.attack = random.Next(54, 1000);
            this.defense = random.Next(7, 1500);
        }
    }
}
