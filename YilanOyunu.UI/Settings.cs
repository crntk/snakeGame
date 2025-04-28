using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilanOyunu.UI
{
    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string directions;
        public Settings()
        {
            Width = 18;
            Height = 18;
            directions= "left"; 
        }
    }
}
