using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScintillaSearch
{
    internal class Common
    {
        private static Dictionary<Control, ToolTip> DefinedToolTipArray = new Dictionary<Control, ToolTip>();

        public static bool SetToolTip(Control control, string tooltip)
        {
            try
            {
                if (DefinedToolTipArray.ContainsKey(control)) { return false; }
                ToolTip tp = new ToolTip();
                tp.SetToolTip(control, tooltip);
                DefinedToolTipArray.Add(control, tp);
                return true;
            }
            catch (Exception/* ex*/) { }
            return false;
        }

        public static bool RemoveToolTip(Control control)
        {
            try
            {
                if (DefinedToolTipArray.ContainsKey(control)) {
                    DefinedToolTipArray[control].RemoveAll();
                    DefinedToolTipArray[control].Dispose();
                    DefinedToolTipArray.Remove(control);
                    return true; 
                }
                return false;
            }
            catch (Exception/* ex*/) { }
            return false;
        }
    }
}
