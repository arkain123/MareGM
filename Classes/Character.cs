using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Dcharlist
{
    internal class Character
    {
        // Базовая инфа
        private string name = "";
        private string ch_class = "";
        private string race = "";
        private string background = "";
        private string ideology = "";
        private int experience = 0;
        private int level = 0;
        private int weight = 0;
        private int height = 0;
        private int storage = 0;
        private int max_storage = 0;

        // Атрибуты
        private int strength = 0;
        private int strength_modifier = 0;
        private int agility = 0;
        private int agility_modifier = 0;
        private int physique = 0;
        private int physique_modifier = 0;
        private int intelligence = 0;
        private int intelligence_modifier = 0;
        private int wisdom = 0;
        private int wisdom_modifier = 0;
        private int charisma = 0;
        private int charisma_modifier = 0;

        // Навыки
        private bool acrobatics = false;
        private bool analysis = false;
        private bool athletics = false;
        private bool perception = false;
        private bool survival = false;
        private bool perfomance = false;
        private bool intimidation = false;
        private bool history = false;
        private bool dexterity = false;
        private bool magic = false;
        private bool medicine = false;
        private bool deception = false;
        private bool nature = false;
        private bool insight = false;
        private bool religion = false;
        private bool secrecy = false;
        private bool belief = false;
        private bool animal_care = false;

        // Спасброски Атрибуты
        private int strength_savthrow = 0;
        private int agility_savthrow = 0;
        private int physique_savthrow = 0;
        private int intelligence_savthrow = 0;
        private int wisdom_savthrow = 0;
        private int charisma_savthrow = 0;

        // Спасброски Навыки
        private int acrobatics_savthrow = 0;
        private int analysis_savthrow = 0;
        private int athletics_savthrow = 0;
        private int perception_savthrow = 0;
        private int survival_savthrow = 0;
        private int perfomance_savthrow = 0;
        private int intimidation_savthrow = 0;
        private int history_savthrow = 0;
        private int dexterity_savthrow = 0;
        private int magic_savthrow = 0;
        private int medicine_savthrow = 0;
        private int deception_savthrow = 0;
        private int nature_savthrow = 0;
        private int insight_savthrow = 0;
        private int religion_savthrow = 0;
        private int secrecy_savthrow = 0;
        private int belief_savthrow = 0;
        private int animal_care_savthrow = 0;

        // Другое
        private int armor = 10;
        private int initiative = 0;
        private int speed = 30;
        private bool inspiration = false;
        private int ownership_bonus = 0;
        private int pasive_persception = 0;

        // Хп
        private int health = 0;
        private int max_health = 0;
        private int temporal_health = 0;
        private int health_dice = 0;
        private int success_healththrow = 0;
        private int failure_healththrow = 0;

        // Деньги
        private int copper_coins = 0;
        private int silver_coins = 0;
        private int gold_coins = 0;
        private int electrum_coins = 0;
        private int platinum_coins = 0;

        // Списки
        private List<string> possesions = new List<string>(); //владения
        private List<string> inventory = new List<string>();
        private List<string> abilities = new List<string>();

        private List<string> attacks = new List<string>();

        // Черты характера
        private List<string> traits = new List<string>();
        private List<string> ideals = new List<string>();
        private List<string> affections = new List<string>();
        private List<string> weaknesses = new List<string>();

        private List<string> spells = new List<string>();
    }
}
