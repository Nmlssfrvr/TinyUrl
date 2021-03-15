using System;
using System.Collections.Generic;

namespace TinyUrl
{
    class Program
    {
        public class Codec 
        {
            static Dictionary<string,string> Shortener;
    
            public string Encode(string longUrl) 
            {
        
                string tinyurl = "http://your.site/"+longUrl.GetHashCode().ToString("X");
                if(!Shortener.ContainsKey(tinyurl))
                    Shortener.Add(tinyurl,longUrl);
                return tinyurl;
            }
    
            public string Decode(string shortUrl) 
            {
                if(Shortener.ContainsKey(shortUrl))
                    return Shortener[shortUrl];
                return "";
            }
            public Codec()
            {
                Shortener = new Dictionary<string,string>();
            }
}

        static void Main(string[] args)
        {
            Codec codec = new Codec();
            Console.WriteLine("Encoding https://leetcode.com/");
            Console.WriteLine("Short Url {0}",codec.Encode("https://leetcode.com/"));
        }
    }
}
