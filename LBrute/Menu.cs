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
            try
            {
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
[2] = Lella
[3] = Habbok
[4] = Iron

[5] -> Parar
[6] => Retornar

");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("=> ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Brute.hotel = "Habblive";
                        Brute.ConfigureHotel();
                        break;
                    case 2:
                        Brute.hotel = "Lella";
                        Brute.ConfigureHotel();
                        break;
                    case 3:
                        Brute.hotel = "Habbok";
                        Brute.ConfigureHotel();
                        break;
                    case 4:
                        Brute.hotel = "Iron";
                        Brute.ConfigureHotel();
                        break;
                    case 5:
                        Brute.executando = false;
                        break;
                    case 6:
                        Brute.executando = true;
                        break;
                    default:
                        break;
                }
                Brute.Start();
                UpdateTitle();
                Show();
                Brute.form.Clear();
            }
            catch { Show(); }
        }

        public static void UpdateTitle()
            => Console.Title = $"LBrute 🔑 Crackeadas: {Brute.crackeadas} | Inválidas: {Brute.invalidas} | Total: {total} | Hotel: {Brute.hotel} / BruteForce ON: {Brute.executando}";
        

    }
}
