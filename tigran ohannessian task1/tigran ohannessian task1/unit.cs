using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{
    public abstract class unit
    {
        // declearing some protected ints

        protected int X;

        protected int Y;

        protected string Team;

        protected int HP;

        protected int MaxHp;

        protected int Speed;

        protected int Attack;

        protected int Team2;

        protected int ATKrange;

        protected string wenATKimage;


        ///i dont understand how to use these properly but as i understand wer gaining access to our protected class





        public abstract int speed
        {
            get;
            set;
        }

        public abstract string team
        {
            get;
            set;
        }

        public abstract int attack
        {
            get;
            set;
        }

        public abstract int y
        {
            get;
            set;
        }

        public abstract int x
        {
            get;
            set;
        }

        public abstract string wenatkimg
        {
            get;
            set;
        }
        public abstract int atkRNG
        {
            get;
            set;
        }

        public abstract int team2
        {
            get;
            set;
        }
        public abstract int hp
        {
            get;
            set;
        }

        public abstract int maxhp
        {
            get;
            set;
        }
        public abstract int nearunit
        {
            get;
            set;
        }

        public abstract void posnew(int x, int y);
        public abstract void fighting(int health, int attack, ref unit attack1);
        public abstract bool rngcheck(int x, int y, ref unit attack);
        public abstract unit nearestUnit(int x, int y);
        public abstract void death(int health, int x, int y);
        public abstract override string ToString();
    }

}




