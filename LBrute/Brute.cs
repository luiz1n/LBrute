using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBrute
{
    class Brute
    {
        public static int crackeadas, invalidas;
        public static string hotel = "?";

        public static string LoginUrl, MeUrl;

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
            if(hotel.ToLower() == "habblive"){
                LoginUrl = "https://habblive.in/";
                MeUrl = "https://habblive.in/me";
            }
        }


        private async static void InitBrute( string username, string hotel, Dictionary<string, string> form){
            foreach (var password in File.ReadAllLines("senhas.txt")){
                
                

            }
        }

        public static void Start(string hotel, Dictionary<string, string> form ){
            foreach(var username in File.ReadAllLines("usuarios.txt")){
                InitBrute(username, hotel, form);
            }
        }

    }
}
