namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tao ra 3 nut
            Button btnAsa = new Button("ASA");
            Button btnHiru = new Button("HIRU");
            Button btnBan = new Button("BAN");

            //Gan su kien OnClick cho 3 nut
            btnAsa.OnClick += BtnAsa_OnClick;
            btnHiru.OnClick += BtnHiru_OnClick;
            btnBan.OnClick += BtnBan_OnClick;

            //Mo phong 1 app gom co 3 nut: ASA, HIRU, BAN
            while (true)
            {
                Console.WriteLine("1. Button ASA");
                Console.WriteLine("2. Button HIRU");
                Console.WriteLine("3. Button BAN");
                Console.WriteLine("Please click a button: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            btnAsa.click();
                            break;
                        }
                    case 2:
                        {
                            btnHiru.click();
                            break;
                        }
                    case 3:
                        {
                            btnBan.click();
                            break;
                        }
                }
            }
        }

        private static void BtnBan_OnClick(string name)
        {
            Console.WriteLine("You clicked " + name);
        }

        private static void BtnHiru_OnClick(string name)
        {
            Console.WriteLine("You clicked " + name);
        }

        private static void BtnAsa_OnClick(string name)
        {
            Console.WriteLine("You clicked " + name);
        }
    }
}