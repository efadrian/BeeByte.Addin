﻿using Microsoft.Office.Tools.Ribbon;

namespace PowerPointAddIn
{
    public partial class Ribbon
    {
      
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            _pptApp = Globals.ThisAddIn.Application;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            _myClass.AddSlide(_pptApp);
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            _myClass.RemoveSlide(_pptApp);
        }
    }
}