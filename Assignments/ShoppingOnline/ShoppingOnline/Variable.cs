using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline
{
    public class Variable
    {
        public static ResourceManager rm = new ResourceManager("ShoppingOnline.Resources.pants", Assembly.GetExecutingAssembly());
        // List Controls
        private static List<Control> listControls = new List<Control>();
        public static List<Control> ListControls { get { return listControls; } set { listControls = value; } }
    }
}
