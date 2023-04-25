using Newtonsoft.Json;
using RestSharp;

class Program {
        public static void Main (string[] args) {
        
var client = new RestClient("https://api.chess.com/pub/titled/GM");
            var request = new RestRequest("/", Method.Get);
            RestResponse response = client.Execute(request);
            String content = response.Content;
Chess menu = JsonConvert.DeserializeObject<Chess>(content);

Console.WriteLine(menu.players[3]);

var playerclient = new RestClient("https://api.chess.com/pub/player/");
            var playerRequest = new RestRequest("/", Method.Get);
            RestResponse playerResponse = playerclient.Execute(request);
            String playercontent = response.Content;
Player playermenu = JsonConvert.DeserializeObject<Player>(content);

Console.WriteLine(playermenu.player_id[1stsecond]);
        }
public class Chess
    {
        public List<string> players { get; set; }
    }

//https://api.chess.com/pub/player/{player}

public class Player
    {
        public string avatar { get; set; }
        public int player_id { get; set; }

        [JsonProperty("@id")]
        public string id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public int followers { get; set; }
        public string country { get; set; }
        public int last_online { get; set; }
        public int joined { get; set; }
        public string status { get; set; }
        public bool is_streamer { get; set; }
        public bool verified { get; set; }
        public string league { get; set; }
    }
        }
