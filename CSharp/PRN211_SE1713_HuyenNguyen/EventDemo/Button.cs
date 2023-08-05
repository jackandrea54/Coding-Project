using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    // Lop nay xay dung len 1 nut
    public class Button
    {
        public string Name { get; set; }
        public Button()
        {

        }

        public Button(string name)
        {
            Name = name;
        }

        // Xay dung ham mo phong thao tac nhan nut
        public void click()
        {
            // kich hoat su kien nhan nut
            if (OnClick != null) //neu nut duoc gan su kien OnClick
            {
                OnClick(Name);
            }
            else
            {
                Console.WriteLine("Chua gan su kien cho nut " + Name);
            }
        }

        //tao su kien nhan nut cho 1 button
        public delegate void handle(string name);

        public event handle OnClick; //su kien xay ra khi nhan nut
    }
}
