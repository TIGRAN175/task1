using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{


            class Meleeunit : unit 


    {


        private int meleeunit;
        public int MeleeunitTarget
        {
            get { return MeleeunitTarget; }

            set { MeleeunitTarget = value; }

        }



        //best attempt at a constructor 
        public Meleeunit(int CostofUnit, string name, string wenATKimage, int team, int x, int y, int health,
                         int attack, int atkRNG, int speed, int team2)
        {
           
            base.Team = Team;
            base.X = x;
            base.Y = y;
            base.Team2 = team2;
            base.wenATKimage = wenATKimage;
            base.HP = health;
            base.Attack = attack;
            base.Speed = speed;
            base.ATKrange = atkRNG;
           
        }

        public override void posnew(int x, int y)
        { 

            //Goes to the Closest Unit of Last remaining and attacks at close
         







           
            {    if (HP < 15) //tells our units to flee
                {
                    Random r = new Random();
                    switch (r.Next(0, 2))
                    {
                        case 0: x += (1 * speed); break;
                        case 1: x -= (1 * speed); break;
                    }

                    switch (r.Next(0, 2))
                    {
                        case 0: y += (1 * speed); break;
                        case 1: y -= (1 * speed); break;
                    }

                    //making sure our units are within the map
                    if (x <= 0)
                    {
                        x = 0;
                    }
                    else if (x >= 20)
                    {
                        x = 20;
                    }

                    if (y <= 0)
                    {
                        y = 0;
                    }
                    else if (y >= 20)
                    {
                        y = 20;
                    }
                }
            }
        }


        // trying to handel our fighting 
     

        public override void fighting(int Health, int attack1)
        {
            HP = HP - attack1;
        }



        public override void fighting(ref unit attacker)
        {
            this.HP = this.HP - attacker.attack1;
            if (HP <= 0)
            {
                DeathDestruction();
            }
        }


        private void DeathDestruction()
        {
            throw new NotImplementedException();
        }

        public override void death(int Health, int x, int y)
        {
            if (Health <= 0)
            {
                { wenatkimg = "C"; }
            }
        }

        public override void nearestUnit(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void nearestUnit(int X, int Y)
        {
            Boolean Range = false;
            if (MeleeunitTarget <= 1)
            {
                Range = true;
            }
        }

        public override String ToString()
        {
            return "Unit Health :" + HP + "/n Unit Speed: " + Speed + "/n Unit Attack: " + Attack +
                   "/n Unit RangeAttack: " + ATKrange + "/n Unit Team: " + team;
        }
    }
}

