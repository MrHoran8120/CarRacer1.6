using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacer1._6
{
    public class Car : Label
    {
        public string Rego { get; set; }
        public Color   Paint { get; set; }
        public System.Windows.Forms.Timer UpdateTimer { get; set; }

        public Car(string rego, Color paint, Timer updateTimer)
        {
            Rego = rego;
            Paint = paint;
            UpdateTimer = updateTimer;

            // update Timer attributes
            UpdateTimer.Interval = 50;
            UpdateTimer.Enabled = false;
            UpdateTimer.Tick += UpdateTimer_Tick;

            // setup some label attributes
            BackColor = Paint;
            Text = Rego;
            Size = new Size(100, 30);
            Location = new Point(1, 100);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("I ticked, I am " + Rego + " " + DateTime.Now);

            Point newLoc = new Point(Location.X + 5, Location.Y);
            Location = newLoc;
        }
    }
}
