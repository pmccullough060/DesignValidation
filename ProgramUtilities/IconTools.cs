﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramUtilities
{
    public class IconTools
    {
        private class IconToolsAxHost : System.Windows.Forms.AxHost
        {
            private IconToolsAxHost() : base(string.Empty) { }

            public static Image GetImageFromIPicture(object iPicture)
            {
                return GetPictureFromIPicture(iPicture);
            }
        }

        public static Image GetImage(stdole.IPictureDisp iPictureDisp)
        {
            return IconToolsAxHost.GetImageFromIPicture(iPictureDisp);
        }
    }
}
