using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GmaeRpgGG
{
    public class Human
    {

        protected int _hp;
        protected string _name;
        protected int _damage;

        public int GetHp()
        {
            return _hp;
        }

        public Human(string name,int hp,int attack)
        {
            _name = name;
            _hp = hp;
            _damage=attack;
            
        }

        public virtual void GetHit(int dmg)
        {
            _hp -= dmg;
        }

        public void Attack(Human enemy)
        {
            enemy.GetHit(_damage);
        }
        
        public void BAFF(int dmg)
        {
            _damage += dmg;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Информация о персонаже \n Имя:{_name},\n Хп:{_hp},\n Дамаг:{_damage}");
        }
    }
    public class Berserk : Human
    {
        public Berserk(string name, int hp, int attack) : base(name, hp, attack)
        {
            _name = "Берсерк " + _name;
        }

        public override void GetHit(int dmg)
        {
            _hp -= dmg / 2;
        }
    }

    public class URMOM : Human
    {
        public URMOM(string name, int hp, int attack) : base(name,hp,attack)
        {
            _name = "URMOM " + name;
        }
        public override void GetHit(int dmg)
        {
            _hp -= dmg / 100; 
        }
    }

    public class Monster
    {
        protected string _name;
        protected int _hp;
        protected int _damage;
        public Monster(string name, int hp, int attack)
        {
            name = _name;
            hp = _hp;
            attack = _damage;
        }

        public virtual void GetHit(int dmg)
        {
            _hp -= dmg;
        }

        public void Attack(Human enemy)
        {
            enemy.GetHit(_damage);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Информация о монстре \n Название:{_name},\n Хп:{_hp},\n Дамаг:{_damage}");
        }
    }
}
