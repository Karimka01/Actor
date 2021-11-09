using System;
using System.Collections.Generic;
using System.Text;

namespace _08._06._21
{  
   public enum HeroClass
   {
       Archer
   }
    class Hero : Bow
    {
        public string name { get=>"Jonh"; private set { } }
        public int strenght { get; set; }
        public string description { get => "Black hair, Red eyes."; private set { } }
        public HeroClass heroClass { get; private set; }
        public Hero()
        {
            heroClass = HeroClass.Archer;
        }
        public string Jump()
        {
            return "*Очень высоко прыгает~*";
        }
        public string Run()
        {
            return "*Не может нормально бежать, без остановки прыгает*";
        }
        public string Stand()
        {
            return "*Прыгает на месте*";
        }
        public string Swim()
        {
            return "*Плывёт и бултыхается в верх одноврменно*";
        }
    }
    class Bow
    {
        public int CritChance { get ; set; }
        public int RangeDamage { get ; set; }
    }

}



        
