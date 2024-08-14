using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Dcharlist
{
    internal class Weapon
    {
        private string name = "weapon";
        private string description = null;
        private string weapon_class = null;
        private int cost = 0;
        private int damage_dice = 0;
        private int count_dice = 1;
        private string damage_type = null;
        private double weight = 0;
        private int alternate_damage = 0;
        private int range = 0;
        private bool isUniversal = false;
        private bool isRanged = false;
        private bool isTwoHanded = false;
        private bool isReacheable = false;
        private bool isLight = false;
        private bool isThrowable = false;
        private bool isSpecial = false;
        private bool isReloading = false;
        private bool isHeavy = false;
        private bool isFencing = false;
    }
}
