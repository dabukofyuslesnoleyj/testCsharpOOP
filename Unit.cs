using System;

namespace testCsharpOOP
{
    abstract class Unit
    {
        protected string id {get; set;}
        protected string name {get; set;}

        public float _str {get; set;}
        public float _agi {get; set;}
        public float _int {get; set;}

        protected int maxHP;
        protected int maxMP;
        protected int armor;
        protected int currHP;
        protected int currMP;
        protected int meanAttack;
        protected int attackVariance;

        public Unit (){
            
        }

    }
}
