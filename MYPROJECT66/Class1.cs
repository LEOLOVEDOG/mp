using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MYPROJECT66
{
    internal class Class1
    {
        [DllImport("user32")]
        public static extern int SetParent(IntPtr hWnd, IntPtr hParent);

        
    }
}
