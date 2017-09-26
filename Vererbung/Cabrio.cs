using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung
{
    internal class Cabrio : Pkw
    {
        public Cabrio(string farbe) : base(farbe)
        { }

        private string dachart;
        public string Dachart
        {
            get
            {
                return dachart;
            }
            set
            {
                dachart = value;
            }
        }
    }
}