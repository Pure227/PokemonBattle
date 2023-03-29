using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Pokemon
{
    public class Pokemons
    {
        protected string name;
        protected int hp;
        protected int attack;
        protected int defense;
        protected int speed;
        protected Bitmap _image;

        public Bitmap getImage() { return this._image; }
        public string getName() { return this.name; }
        public int getHp() { return this.hp; }
        public int getAttack() { return this.attack; }
        public int getDefense() { return this.defense; }
        public int takeDamage(int damage)
        {
            this.hp -= damage;
            return this.hp;
        }
    }
}
