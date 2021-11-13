using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBrute
{
    class Menu
    {

        public static void Show() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 __        _______                         __               
|  \      |       \                       |  \              
| $$      | $$$$$$$\  ______   __    __  _| $$_     ______  
| $$      | $$__/ $$ /      \ |  \  |  \|   $$ \   /      \ 
| $$      | $$    $$|  $$$$$$\| $$  | $$ \$$$$$$  |  $$$$$$\
| $$      | $$$$$$$\| $$   \$$| $$  | $$  | $$ __ | $$    $$
| $$_____ | $$__/ $$| $$      | $$__/ $$  | $$|  \| $$$$$$$$
| $$     \| $$    $$| $$       \$$    $$   \$$  $$ \$$     \
 \$$$$$$$$ \$$$$$$$  \$$        \$$$$$$     \$$$$   \$$$$$$$

                     made by Luiz1n ~ FuckRetros
                     github.com/luiz1n
                                                            
[1] = Habblive
[2] = Habblet
[3] = Lella
[4] = AgeHotel
[5] = Habbox
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("=> ");
            int option = int.Parse(Console.ReadLine());
            switch (option){
                case 1:
                    break;
            }
            Menu.Show();
        }

        public static void UpdateTitle(){ 
            
        }

    }
}
