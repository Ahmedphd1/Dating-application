using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datingapp
{
   public class matchfound
    {
        public delegate void matchfoundeventhandler(object source, EventArgs args); // defining a delegate that hold functions


        public event matchfoundeventhandler matchfoundhandler; // converting the delegate to be an event also

        public void triggermatch() // our method that triggers the event
        {
            onmatchfound(); // triggers the event handler
        }

        protected virtual void onmatchfound() // method that triggers the delegate
        {
            if (matchfoundhandler != null) // trigger the delegate
                matchfoundhandler(this, EventArgs.Empty);
        }
    }
}
