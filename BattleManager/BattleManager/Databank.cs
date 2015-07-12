using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager
{
    /*
     * 
     * Myvar:
     * Some seruis star trek refrinses going on here lol
     * 
     */
    public class Databank
    {
        public List<string> UIDS = new List<string>();
        public Dictionary<string, List<int>> IDGameList = new Dictionary<string, List<int>>();
        public List<int> AllGamesEverPlayed = new List<int>();


        public static void SaveToFile(Databank db)
        {
            
        }

        public Databank LoadFromFIle(string  dbf)
        {
            return null;
        }
    }
}
