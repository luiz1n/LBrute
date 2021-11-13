using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBrute
{
    class Menu
    {
        public static int total = File.ReadAllLines("usuarios.txt").Length;
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
            Console.Title = $"LBrute 🔑 Crackeadas: {Brute.crackeadas} | Inválidas: {Brute.invalidas} | Total: {total} | Hotel: {Brute.hotel}";
        }

    }
}
