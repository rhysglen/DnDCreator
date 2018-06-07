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
            
            }
            else if (race == "Half-Orc")
            {

            }
            else if (race == "Elf")
            {

            }
            else if (race == "Dwarf")
            {

            }
            else if (race == "Human")
            {

            }
            else if (race == "Tiefling")
            {

            }
            else if (race == "Halfling")
            {

            }
            else if (race == "Dragonborn")
            {

            }
            else if (race == "Gnome")
            {

            }

            //CLASSES

            if (type == "Cleric")
            {

            }
            else if (type == "Druid")
            {

            }
            else if (type == "Barbarian")
            {

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
