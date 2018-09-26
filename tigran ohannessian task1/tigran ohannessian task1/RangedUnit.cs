using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{
    
        class RangedUnit : unit
        {

            public RangedUnit( string team2, int x, int y, int HP, int Speed, int attack, int atkRNG, string team, string wenATKimag)
            {



            base.Team = team;
            base.X = x;
            base.Y = y;
            base.Team2 = team2;
            base.wenATKimage = wenATKimage;
            base.HP = hp;
            base.Attack = attack;
            base.Speed = speed;
            base.ATKrange = atkRNG;
        }

            public override void Move(ref unit closestUnit)
            {
                //No unit closest - last reminaing unit 
                if (this == closestUnit)
                {
                    return;
                }

                //only react to enemy units
                if (closestUnit.team != team)
                {
                    if (HP < 0) 
                    
                    //run away

                    {
                        Random r = new Random();


                        switch (r.Next(0, 2))
                        {
                            case 0: x += (1 * Speed); break;


                            case 1: x -= (1 * Speed); break;
                        }

                        switch (r.Next(0, 2))
                        {
                            case 0: y += (1 * Speed); break;


                            case 1: y -= (1 * Speed); break;
                        }

                        //checking the bounds thing 
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

                    // see if its in combat yet
                    else if (InRange(ref nearunit))
                    {
                        fighting(ref closestUnit);
                    }
                    else //move closer to next unit    
                    {
                        if (x > closestUnit.x)
                        {
                            x -= Speed;
                        }
                        else if (x < closestUnit.x)
                        {
                            x += Speed;
                        }

                        if (y > closestUnit.y)
                        {
                            y -= Speed;
                        }
                        else if (y < closestUnit.y)
                        {
                            y += Speed;
                        }
                    }
                }
            }
           
            public override string team
            {
                get { return team; }
                set { team = value; }
            }
            public override int attack
            {
                get { return attack; }
                set { attack = value; }
            }


            public override int y
            {
                get { return y; }



                set { y = value; }
            }

            public override int x
            {
                get { return x; }


                set { x = value; }
            }


            public override string wenatkimg
        {
                get { return wenatkimg; }


                set { wenatkimg = value; }
            }

            public override int team2
            {
                get { return team2; }


                set { team = value; }
            }

            public override void fighting(ref unit attacker)
            {
                this.HP = this.HP - attacker.attack;


                if (HP <= 0)
                {
                    Death();
                }
            }

            public override bool InRange(ref unit attacker)
            {
                if (DistanceTo(attacker) <= atkRNG)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private int DistanceTo(unit unit)
            {
                // matth stuff
                int dy = Math.Abs(unit.y - y);
                int dx = Math.Abs(unit.y - x);

               
                double part = Convert.ToDouble((dx * dx) + (dy * dy));
                return Convert.ToInt32(Math.Sqrt(part));

        }

            public override unit nearestUnit(ref unit[] map)
            {
               unit nearestUnit = this;



                int sminrange = 100;


                foreach (unit u in map)
                {
                    if (minrange > DistanceTo(u) && u != this)
                    {
                        smallestRange = DistanceTo(u);
                        closest = u;
                    }
                }
                return closest;
            }

            public override void death()
            {
                throw new death(this.ToString() + " -has died- ");


            }

            public override string ToString()
            {
            return wenatkimg + ": [" + x + "," + y + "] " + HP + "hp " + attack;
            }
        }


    }




