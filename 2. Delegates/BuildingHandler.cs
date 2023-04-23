using System;
using System.Collections;
using System.Windows.Forms;

namespace Studying
{
    internal class BuildingHandler
    {
        public static readonly Hashtable buildings = new Hashtable();

        public delegate DialogResult Creation(string s);

        public delegate DialogResult Deletion(string s);

        public delegate DialogResult Modification(string s);
    }
}
