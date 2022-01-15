using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datingapp
{
   public class personclass : Interfaceclass
    {
        public string email { get; set; }
        public string passwords { get; set; }

        public string alias { get; set; }
        public string birthsday { get; set; }

        public string køn { get; set; }
        public string hårfarve { get; set; }

        public string øjefarve { get; set; }

        public string matchhårfarve { get; set; }

        public string matchøjefarve { get; set; }

        public string postnummer { get; set; }

        public string bydel { get; set; }
        public bool isinitiated { get; set; }

        public bool checkinitiate()
        {
            if (isinitiated)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
