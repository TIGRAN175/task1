using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tigran_ohannessian_task1
{
    class GameEngine
    {


        public MAP mymap = new MAP();
        private Form1 form;
        private GroupBox messageGroup;

        public GameEngine(Form1 form, GroupBox messageGroup)
        {
            this.form = form;
            this.messageGroup = messageGroup;
            foreach (unit u in mymap.units)
            {
                Button b = new Button();



                




                b.Text = u.wenatkimg;

                b.Location = new Point(u.y * 35, u.y * 35);
                b.Size = new Size(30, 30);

                if (u.Team == 0)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if (u.GetType() == typeof(Meleeunit))
                {
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;
                this.form.Controls.Add(b);
            }
        }

        public void UpdateDisplay()
        {
            form.Controls.Clear();
            form.Controls.Add(messageGroup);
            foreach (unit  u in mymap.unit)
            {
                Button b = new Button();
                b.Location = new Point(u.x * 35, u.y * 35);
                b.Size = new Size(30, 30);
                b.Text = u.wenatkimg;

                if (u.team2 == 0)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if (u.GetType() == typeof(Meleeunit))
                {
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;
                form.Controls.Add(b);
            }
        }

        public void UpdateMap()
        {
            foreach (unit u in mymap.unit)
            {
                unit nearunit = u.nearestUnit(ref mymap.unit);

                try
                {
                    u.Move(ref nearunit);
                }
                catch (death d)
                {
                    form.displayInfo(d.Message);
                    unit[] temp = new unit[mymap.unit.Count() - 1];
                    int j = 0;
                    for (int i = 0; i < mymap.unit.Count(); i++)
                    {
                        if (u != mymap.unit[i])
                        {
                            temp[j++] = mymap.unit[i];
                        }
                    }

                    mymap.unit = temp;
                }
            }
        }

        public void buttonClick(object sender, EventArgs args)
        {
            foreach (unit u in mymap.unit)
            {
                if (((Button)sender).Text == u.wenatkimg)
                {
                    form.displayInfo(u.ToString()); // ((Button)sender).Left + " " + ((Button)sender).Right);
                    break;
                }
            }
        }
    }
}
