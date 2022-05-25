using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription()
        {
            string description = "";
            if (ShininessLevel < 2)
            {
                description = "Dull";

            }
            else if (ShininessLevel >= 2 && ShininessLevel <= 5)
            {
                description = "Noticeable";
            }
            else if (ShininessLevel >= 6 && ShininessLevel <= 9)
            {
                description = "Bright";
            }
            else
            {
                description = "Blinding";
            }

            return description;





        }
    }
}
