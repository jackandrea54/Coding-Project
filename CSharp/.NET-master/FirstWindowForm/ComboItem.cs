using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowForm
{
    internal class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public ComboItem(int iD, string text)
        {
            ID = iD;
            Text = text;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
