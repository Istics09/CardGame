using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    internal class Card_Actions
    {
        public void Mouse_Enter(object sender, EventArgs e)
        {
            PictureBox entered = sender as PictureBox;
            if(entered != null)
            {
                entered.Location = new Point(entered.Location.X, entered.Location.Y-50);
            }
        }

        public void Mouse_leave(object sender, EventArgs e)
        {
            PictureBox leave = sender as PictureBox;
            if(leave != null)
            {
                leave.Location = new Point(leave.Location.X, leave.Location.Y+50);
            }
        }
    }
}
