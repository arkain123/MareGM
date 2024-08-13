using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Dcharlist
{
    internal class Armor
    {
        private string name = "armor";
        private string description;
        private string armor_class = null; //heavy / light / medium / shield
        private int armor_stat = 10;
        private string armor_att = null;
        private int armor_att_max;
        private int cost = 0;
        private int req_strength;
        private bool stealth_impediment = false;
        private int weight;
    }
}
