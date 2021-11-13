using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LBrute
{
    class Brute
    {
        public static int crackeadas, invalidas;
        public static string hotel = "?";

        public static string LoginUrl, MeUrl;
        public static Dictionary<string, string> form = new();

        public static void ConfigureHotel(){

            switch (hotel.ToLower()){
                case "habblive":
                    LoginUrl = "https://habblive.in/";
                    MeUrl = "https://habblive.in/me";
                    break;
                case "lella":
                    LoginUrl = "https://lella.ws/api/login";
                    MeUrl = "https://lella.ws/me";
                    break;
                case "habbok":
                    LoginUrl = "https://habbok.me/";
                    MeUrl = "https://habbok.me/me";
                    break;
                case "iron":
                    LoginUrl = "https://ironhotel.biz/callback/bruteLogin";
                    MeUrl = "https://ironhotel.biz/me";
                    break;
            }
        }

        private static async void Checker(Dictionary<string, string> form) 
        {
            using (HttpClient client = new HttpClient()) 
            {

            }
        }

        private static async void Habblive(string username, string password) 
        {
            
        }

        private static async void Lella(string username, string password) { }
        private static async void Habbok(string username, string password) { }
        private static async void Iron(string username, string password) { }


        private static void InitBrute(string username){
            foreach (var password in File.ReadAllLines("senhas.txt")) {
                


            }
        }

        public static void Start(){
            foreach(var username in File.ReadAllLines("usuarios.txt")){
                InitBrute(username);
            }
        }

    }
}
