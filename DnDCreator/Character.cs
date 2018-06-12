using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCreator
{
   

    public class Character
    {
        public List<string> skills = new List<string>();
        public List<string> equipment = new List<string>();
        public List<string> languages = new List<string>();
        public List<string> proficiencies = new List<string>();
        public List<string> traits = new List<string>();
        public List<weapons> weapon = new List<weapons>();


        public string name, race, type, background; 
            
        public int strength, dexterity, constitution, inteligence, wisdom, charisma;

        public int armorClass, speed, hitPoints; 

        public int strMod, dexMod, constMod, intMod, wisMod, chaMod = 0;

        public int strST, dexST, constST, intST, wisST, chaST;

        public int proficiency = 2;

        public string hitDie;



        public Character(string _name, string _race, string _type, string _background, int _strST, int _dexST, int _constST, int _intST, int _wisST, int _chaST,int _proficiency, int _strength, int _dexterity, int _constitution, int _inteligence, int _wisdom, int _charisma, int _armorClass, int _speed, int _hitPoints, string _hitDie, int _strMod, int _dexMod, int _constMod, int _intMod, int _wisMod, int _chaMod, List<string> _skills, List<string> _languages, List<string> _proficiencies, List<string> _equipment, List<string> _traits, List<weapons> _weapon)
        {
            name = _name;
            race = _race;
            type = _type;
            background = _background;
            strength = _strength;
            dexterity = _dexterity;
            constitution = _constitution;
            inteligence = _inteligence;
            wisdom = _wisdom;
            charisma = _charisma;
            armorClass = _armorClass;
            speed = _speed;
            hitPoints = _hitPoints;
            hitDie = _hitDie;
            skills = _skills;
            equipment = _equipment;
            languages = _languages;
            proficiencies = _proficiencies;
            traits = _traits;
            weapon = _weapon;
            strMod = _strMod;
            dexMod = _dexMod;
            constMod = _constMod;
            intMod = _intMod;
            wisMod = _wisMod;
            chaMod = _chaMod;
            proficiency = _proficiency;
            strST = _strST;
            dexST = _dexST;
            constST = _constST;
            intST = _intST;
            wisST = _wisST;
            chaST = _chaST;



            //RACES
            if (race == "Half-Elf")
            {
                charisma = charisma + 2;
                //TODO: add in the function of choosing 2 ability scores
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Fey Ancestry");
                proficiencies.Add("Skill Versatility");
                //TODO: add in the function of choosing 2 skills
                languages.Add("Common");
                languages.Add("Elvish");
                languages.Add("One Extra"); 

            }
            else if (race == "Half-Orc")
            {
                strength = strength + 2;
                constitution = constitution + 1;
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Menacing");
                traits.Add("Relentless Endurance");
                traits.Add("Savage Attacks");
                languages.Add("Common");
                languages.Add("Orc");
                skills.Add("Intimidation");

            }
            else if (race == "High Elf")
            {
                dexterity = dexterity + 2;
                inteligence = inteligence + 1;
                traits.Add("Elf Weapon Training");
                proficiencies.Add("Longsword");
                proficiencies.Add("Shortsword");
                proficiencies.Add("Shortbow");
                proficiencies.Add("Longbow");
                traits.Add("Extra Cantrip");
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Keen Senses");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");
                languages.Add("Common");
                languages.Add("Elvish");
                languages.Add("One Extra");
                skills.Add("Perception");
            }
            else if (race == "Wood Elf")
            {
                dexterity = dexterity + 2;
                wisdom = wisdom + 1;
                proficiencies.Add("Elf Weapon Training");
                proficiencies.Add("Longsword");
                proficiencies.Add("Shortsword");
                proficiencies.Add("Shortbow");
                proficiencies.Add("Longbow");
                traits.Add("Fleet Footed");
                traits.Add("Mask of the Wild");
                speed = 35;
                traits.Add("Darkvision");
                traits.Add("Keen Senses");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");
                languages.Add("Common");
                languages.Add("Elvish");
                skills.Add("Perception");
            }
            else if (race == "Dark Elf")
            {
                dexterity = dexterity + 2;
                charisma = charisma + 1;
                traits.Add("Drow Weapon Training");
                proficiencies.Add("Rapier");
                proficiencies.Add("Shortsword");
                proficiencies.Add("Hand Crossbow");
                traits.Add("Drow Magic");
                traits.Add("Sunlight Sensitivity");
                speed = 35;
                traits.Add("Superior Darkvision");
                traits.Add("Keen Senses");
                skills.Add("Perception");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");
                languages.Add("Common");
                languages.Add("Elvish");
            }
            else if (race == "Hill Dwarf")
            {
                constitution = constitution + 2;
                wisdom = wisdom + 1;
                traits.Add("Dwarven Toughness");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Dwarven Resilience");
                traits.Add("Dwarven Combat Training");
                proficiencies.Add("Battleaxe");
                proficiencies.Add("Handaxe");
                proficiencies.Add("Light Hammer");
                proficiencies.Add("Warhammer");
                traits.Add("Stonecutting");
                traits.Add("Artisan Tool Proficiency");
                languages.Add("Common");
                languages.Add("Dwarvish");
            }
            else if (race == "Mountain Dwarf")
            {
                constitution = constitution + 2;
                strength = strength + 2;
                traits.Add("Dwarven Armor Training");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Light Armor");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Dwarven Resilience");
                traits.Add("Dwarven Combat Training");
                proficiencies.Add("Battleaxe");
                proficiencies.Add("Handaxe");
                proficiencies.Add("Light Hammer");
                proficiencies.Add("Warhammer");
                traits.Add("Stonecutting");
                traits.Add("Artisan Tool Proficiency");
                languages.Add("Common");
                languages.Add("Dwarvish");
            }
            else if (race == "Human")
            {
                strength = strength + 1;
                dexterity = dexterity + 1;
                constitution = constitution + 1;
                inteligence = inteligence + 1;
                wisdom = wisdom + 1;
                charisma = charisma + 1;
                speed = 30;
                languages.Add("Common");
                languages.Add("One Extra");
            }
            else if (race == "Tiefling")
            {
                inteligence = inteligence + 1;
                charisma = charisma + 2;
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Hellish Resistance");
                traits.Add("Infernal Legacy");
                languages.Add("Common");
                languages.Add("Infernal");
            }
            else if (race == "Lightfoot Halfling")
            {
                dexterity = dexterity + 2;
                charisma = charisma + 1;
                traits.Add("Naturally Stealthy");
                speed = 25;
                traits.Add("Lucky");
                traits.Add("Brave");
                traits.Add("Halfling Nimbleness");
                languages.Add("Common");
                languages.Add("Halfling");
            }
            else if (race == "Stout Halfling")
            {
                dexterity = dexterity + 2;
                constitution = constitution + 1;
                traits.Add("Stout Resilience");
                speed = 25;
                traits.Add("Lucky");
                traits.Add("Brave");
                traits.Add("Halfling Nimbleness");
                languages.Add("Common");
                languages.Add("Halfling");
            }
            else if (race == "Dragonborn")
            {
                strength = strength + 2;
                charisma = charisma + 1;
                speed = 30;
                traits.Add("Dragonic Ancestry");
                traits.Add("Breath Weapon");
                traits.Add("Damage Resistance");
                languages.Add("Common");
                languages.Add("Dragonic");
            }
            else if (race == "Forest Gnome")
            {
                inteligence = inteligence + 2;
                dexterity = dexterity + 1;
                traits.Add("Natural Illusionist");
                traits.Add("Speak with Small Beasts");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Gnome Cunning");
                languages.Add("Common");
                languages.Add("Gnomish");
            }
            else if (race == "Rock Gnome")
            {
                inteligence = inteligence + 2;
                constitution = constitution + 1;
                traits.Add("Artificer's Lore");
                traits.Add("Tinker");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Gnome Cunning");
                languages.Add("Common");
                languages.Add("Gnomish");
            }

            //CLASSES
            //TODO: Come back for skill choice
            if (type == "Cleric")
            {
                hitPoints = 8 + constMod;
                hitDie = "1d8";
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Simple Weapons");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod;
                chaST = chaMod + proficiency;
                equipment.Add("Shield");
                equipment.Add("Holy Symbol");
                traits.Add("Spellcasting");
                traits.Add("Devine Domain");
            }
            else if (type == "Druid")
            {
                hitPoints = 8 + constMod;
                hitDie = "1d8";
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Clubs");
                proficiencies.Add("Daggers");
                proficiencies.Add("Darts");
                proficiencies.Add("Javelins");
                proficiencies.Add("Maces");
                proficiencies.Add("Quarterstaffs");
                proficiencies.Add("Scimitars");
                proficiencies.Add("Sickles");
                proficiencies.Add("Slings");
                proficiencies.Add("Spears");
                proficiencies.Add("Herbalism Kits");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod + proficiency;
                chaST = chaMod;
                equipment.Add("Leather Armor");
                equipment.Add("Druidic Focus");
                equipment.Add("Explorer's Pack");
                traits.Add("Spellcasting");
                traits.Add("Druidic");
            }
            else if (type == "Barbarian")
            {
                hitPoints = 12 + constMod;
                hitDie = "1d12";
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Shields");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Martial Weapons");
                strST = strMod + proficiency;
                dexST = dexMod;
                constST = constMod + proficiency;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod;
                equipment.Add("Explorer's Pack");
                weapons newweapon;
                newweapon = new weapons("Javelin X4", proficiency + strMod, "1d6 Piercing");
                weapon.Add(newweapon);
                //newweapon = new weapons("Battleaxe", proficiency + strMod, "1d8 Slashing");
                //weapon.Add(newweapon);
                traits.Add("Rage");
                traits.Add("Unarmored Defence");
            }
            else if (type == "Rouge")
            {

            }
            else if (type == "Paladin")
            {

            }
            else if (type == "Monk")
            {

            }
            else if (type == "Bard")
            {
                hitDie = "1d8";
                hitPoints = 8 + constMod;
                proficiencies.Add("Light Armor");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Hand Crossbow");
                proficiencies.Add("Longswords");
                proficiencies.Add("Rapiers");
                proficiencies.Add("Shortswords");
                proficiencies.Add("Three Musical Instuments");
                strST = strMod;
                dexST = dexMod + proficiency;
                constST = constMod;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod + proficiency;
                equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger", proficiency + strMod, "1d4 Piercing");
                weapon.Add(newweapon);
                traits.Add("Spellcasting");
                traits.Add("Bardic Inspiration");
                //choose 3 skills 
            }
            else if (type == "Wizard")
            {

            }
            else if (type == "Warlock")
            {

            }
            else if (type == "Sorcerer")
            {

            }
            else if (type == "Fighter")
            {
                hitDie = "1d10";
                hitPoints = 10 + constMod;
                proficiencies.Add("All Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Martial Weapons");
                strST = strMod + proficiency;
                dexST = dexMod;
                constST = constMod + proficiency;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod;
                traits.Add("Fighting Style");
                traits.Add("Second Wind");


            }
            else if (type == "Ranger")
            {

            }

            //BACKGROUND 

            if (background == "Acolyte")
            {

            }
            else if (background == "Charlatan")
            {

            }
            else if (background == "Criminal")
            {

            }
            else if (background == "Entertainer")
            {

            }
            else if (background == "Folk Hero")
            {

            }
            else if (background == "Gladiator")
            {

            }
            else if (background == "Guild Merchant")
            {

            }
            else if (background == "Hermit")
            {

            }
            else if (background == "Knight")
            {

            }
            else if (background == "Noble ")
            {

            }
            else if (background == "Outlander")
            {

            }
            else if (background == "Pirate")
            {

            }
            else if (background == "Sage")
            {

            }
            else if (background == "Sailor")
            {

            }
            else if (background == "Soldier")
            {

            }
            else if (background == "Urchin")
            {

            }
            // abiility modifiers 
            #region strMOD

            switch (strength)
            {
                case 4:
                    strMod = -3;
                    break;
                case 5:
                    strMod = -3;
                    break;
                case 6:
                    strMod = -2;
                    break;
                case 7:
                    strMod = -2;
                    break;
                case 8:
                    strMod = -1;
                    break;
                case 9:
                    strMod = -1;
                    break;
                case 10:
                    strMod = 0;
                    break;
                case 11:
                    strMod = 0;
                    break;
                case 12:
                    strMod = 1;
                    break;
                case 13:
                    strMod = 1;
                    break;
                case 14:
                    strMod = 2;
                    break;
                case 15:
                    strMod = 2;
                    break;
                case 16:
                    strMod = 3;
                    break;
                case 17:
                    strMod = 3;
                    break;
                case 18:
                    strMod = 4;
                    break;
                case 19:
                    strMod = 4;
                    break;
                case 20:
                    strMod = 5;
                    break;
                case 21:
                    strMod = 5;
                    break;
                case 22:
                    strMod = 6;
                    break;
                case 23:
                    strMod = 6;
                    break;
                case 24:
                    strMod = 7;
                    break;
            }
            #endregion

            #region dexMOD
            switch (dexterity)
            {
                case 4:
                    dexMod = -3;
                    break;
                case 5:
                    dexMod = -3;
                    break;
                case 6:
                    dexMod = -2;
                    break;
                case 7:
                    dexMod = -2;
                    break;
                case 8:
                    dexMod = -1;
                    break;
                case 9:
                    dexMod = -1;
                    break;
                case 10:
                    dexMod = 0;
                    break;
                case 11:
                    dexMod = 0;
                    break;
                case 12:
                    dexMod = 1;
                    break;
                case 13:
                    dexMod = 1;
                    break;
                case 14:
                    dexMod = 2;
                    break;
                case 15:
                    dexMod = 2;
                    break;
                case 16:
                    dexMod = 3;
                    break;
                case 17:
                    dexMod = 3;
                    break;
                case 18:
                    dexMod = 4;
                    break;
                case 19:
                    dexMod = 4;
                    break;
                case 20:
                    dexMod = 5;
                    break;
                case 21:
                    dexMod = 5;
                    break;
                case 22:
                    dexMod = 6;
                    break;
                case 23:
                    dexMod = 6;
                    break;
                case 24:
                    dexMod = 7;
                    break;
            }
            #endregion

            #region conMOD

            switch (constitution)
            {
                case 4:
                    constMod = -3;
                    break;
                case 5:
                    constMod = -3;
                    break;
                case 6:
                    constMod = -2;
                    break;
                case 7:
                    constMod = -2;
                    break;
                case 8:
                    constMod = -1;
                    break;
                case 9:
                    constMod = -1;
                    break;
                case 10:
                    constMod = 0;
                    break;
                case 11:
                    constMod = 0;
                    break;
                case 12:
                    constMod = 1;
                    break;
                case 13:
                    constMod = 1;
                    break;
                case 14:
                    constMod = 2;
                    break;
                case 15:
                    constMod = 2;
                    break;
                case 16:
                    constMod = 3;
                    break;
                case 17:
                    constMod = 3;
                    break;
                case 18:
                    constMod = 4;
                    break;
                case 19:
                    constMod = 4;
                    break;
                case 20:
                    constMod = 5;
                    break;
                case 21:
                    constMod = 5;
                    break;
                case 22:
                    constMod = 6;
                    break;
                case 23:
                    constMod = 6;
                    break;
                case 24:
                    constMod = 7;
                    break;
            }
            #endregion

            #region intMOD

            switch (inteligence)
            {
                case 4:
                    intMod = -3;
                    break;
                case 5:
                    intMod = -3;
                    break;
                case 6:
                    intMod = -2;
                    break;
                case 7:
                    intMod = -2;
                    break;
                case 8:
                    intMod = -1;
                    break;
                case 9:
                    intMod = -1;
                    break;
                case 10:
                    intMod = 0;
                    break;
                case 11:
                    intMod = 0;
                    break;
                case 12:
                    intMod = 1;
                    break;
                case 13:
                    intMod = 1;
                    break;
                case 14:
                    intMod = 2;
                    break;
                case 15:
                    intMod = 2;
                    break;
                case 16:
                    intMod = 3;
                    break;
                case 17:
                    intMod = 3;
                    break;
                case 18:
                    intMod = 4;
                    break;
                case 19:
                    intMod = 4;
                    break;
                case 20:
                    intMod = 5;
                    break;
                case 21:
                    intMod = 5;
                    break;
                case 22:
                    intMod = 6;
                    break;
                case 23:
                    intMod = 6;
                    break;
                case 24:
                    intMod = 7;
                    break;
            }
            #endregion

            #region wisMOD

            switch (wisdom)
            {
                case 4:
                    wisMod = -3;
                    break;
                case 5:
                    wisMod = -3;
                    break;
                case 6:
                    wisMod = -2;
                    break;
                case 7:
                    wisMod = -2;
                    break;
                case 8:
                    wisMod = -1;
                    break;
                case 9:
                    wisMod = -1;
                    break;
                case 10:
                    wisMod = 0;
                    break;
                case 11:
                    wisMod = 0;
                    break;
                case 12:
                    wisMod = 1;
                    break;
                case 13:
                    wisMod = 1;
                    break;
                case 14:
                    wisMod = 2;
                    break;
                case 15:
                    wisMod = 2;
                    break;
                case 16:
                    wisMod = 3;
                    break;
                case 17:
                    wisMod = 3;
                    break;
                case 18:
                    wisMod = 4;
                    break;
                case 19:
                    wisMod = 4;
                    break;
                case 20:
                    wisMod = 5;
                    break;
                case 21:
                    wisMod = 5;
                    break;
                case 22:
                    wisMod = 6;
                    break;
                case 23:
                    wisMod = 6;
                    break;
                case 24:
                    wisMod = 7;
                    break;
            }
            #endregion

            #region chaMOD

            switch (charisma)
            {
                case 4:
                    chaMod = -3;
                    break;
                case 5:
                    chaMod = -3;
                    break;
                case 6:
                    chaMod = -2;
                    break;
                case 7:
                    chaMod = -2;
                    break;
                case 8:
                    chaMod = -1;
                    break;
                case 9:
                    chaMod = -1;
                    break;
                case 10:
                    chaMod = 0;
                    break;
                case 11:
                    chaMod = 0;
                    break;
                case 12:
                    chaMod = 1;
                    break;
                case 13:
                    chaMod = 1;
                    break;
                case 14:
                    chaMod = 2;
                    break;
                case 15:
                    chaMod = 2;
                    break;
                case 16:
                    chaMod = 3;
                    break;
                case 17:
                    chaMod = 3;
                    break;
                case 18:
                    chaMod = 4;
                    break;
                case 19:
                    chaMod = 4;
                    break;
                case 20:
                    chaMod = 5;
                    break;
                case 21:
                    chaMod = 5;
                    break;
                case 22:
                    chaMod = 6;
                    break;
                case 23:
                    chaMod = 6;
                    break;
                case 24:
                    chaMod = 7;
                    break;
            }

            #endregion



        }



    }
}
