using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeGame.utils
{
    public static class Printer
    {
        public static void PrintFireworks(string name)
        {
            Console.WriteLine("                                   .''.\r\n       .''.      .        *''*    :_\\/_:     .\r\n      :_\\/_:   _\\(/_  .:.*_\\/_*   : /\\ :  .'.:.'.\r\n  .''.: /\\ :    /)\\   ':'* /\\ *  : '..'.  -=:o:=-\r\n :_\\/_:'.:::.  | ' *''*    * '.\\'/.'_\\(/_'.':'.'\r\n : /\\ : :::::  =  *_\\/_*     -= o =- /)\\    '  *\r\n  '..'  ':::' === * /\\ *     .'/.\\'.  ' ._____\r\n      *        |   *..*         :       |.   |' .---\"|\r\n        *      |     _           .--'|  ||   | _|    |\r\n        *      |  .-'|       __  |   |  |    ||      |\r\n     .-----.   |  |' |  ||  |  | |   |  |    ||      |\r\n ___'       ' /\"\\ |  '-.\"\".    '-'   '-.'    '`      |____\r\njgs~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n  &                    ~-~-~-~-~-~-~-~-~-~   /|\r\n ejm97    )      ~-~-~-~-~-~-~-~  /|~       /_|\\\r\n        _-H-__  -~-~-~-~-~-~     /_|\\    -~======-~\r\n~-\\XXXXXXXXXX/~     ~-~-~-~     /__|_\\ ~-~-~-~\r\n~-~-~-~-~-~    ~-~~-~-~-~-~    ========  ~-~-~-~\r\n\r\n------------------------------------------------\r\nThank you for visiting https://asciiart.website/\r\nThis ASCII pic can be found at\r\nhttps://asciiart.website/index.php?art=holiday/4th%20of%20july\r\n");
            Console.WriteLine($"Thanks for playing {name} !");
        }

        public static void PrintMenu(string name)
        {
            Console.WriteLine("                 _        \r\n                | |       \r\n ___ _ __   __ _| | _____ \r\n/ __| '_ \\ / _` | |/ / _ \\\r\n\\__ \\ | | | (_| |   <  __/\r\n|___/_| |_|\\__,_|_|\\_\\___|");
            Console.WriteLine($"{name} can start !");
        }
    }
}
