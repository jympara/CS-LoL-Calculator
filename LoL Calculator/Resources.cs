using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Calculator
{
    public class Stats
    {

        int Attack_Damage;
        int Attack_Speed;
        int Lethality;
        int Armor_Penetration;
        int Critical_Damage;
        int Critical_Chance;
        int Lifesteal;
        int Armor;
        int Ability_Power;
        int Magic_Penetration;
        int Magic_Penetration_Percent;
        int Magic_Resist;
        int HP;
        int HP_Regen;
        int MP;
        int MP_Regen;
        int Movement_Speed;
        int Cooldown_Reduction;


        public Stats(int Attack_Damage, int Attack_Speed, int Lethality, int Armor_Penetration, int Critical_Damage, int Critical_Chance, 
                    int Lifesteal, int Ability_Power, int Magic_Penetration, int Magic_Penetration_Percent, int Armor, int Magic_Resist,
                    int HP, int HP_Regen, int MP, int MP_Regen, int Movement_Speed, int Cooldown_Reduction                              )
        {

			this.Attack_Damage = Attack_Damage;
			this.Attack_Speed = Attack_Speed;
			this.Lethality = Lethality;
			this.Armor_Penetration = Armor_Penetration;
			this.Critical_Damage = Critical_Damage;
			this.Critical_Chance = Critical_Chance;
			this.Lifesteal = Lifesteal;
			this.Armor = Armor;
			this.Ability_Power = Ability_Power;
			this.Magic_Penetration = Magic_Penetration;
			this.Magic_Penetration_Percent = Magic_Penetration_Percent;
			this.Magic_Resist = Magic_Resist;
			this.HP = HP;
			this.HP_Regen = HP_Regen;
			this.MP = MP;
			this.MP_Regen = MP_Regen;
			this.Movement_Speed = Movement_Speed;
			this.Cooldown_Reduction = Cooldown_Reduction;

		}


    }

	public class Skills
	{

		string Skill_Name;
		Stats Skill_Bonus_Stats;
		string Damage_Type;
		int Base_Damage;
		int Damage_Per_Level;
		bool Damage_Over_Time;
		Dictionary<string, int> Damage_Scale = new Dictionary<string, int>();
		List<object> Extra_Effects = new List<object>();


		public Skills(string Skill_Name, Stats Skill_Bonus_Stats, string Damage_Type, int Base_Damage, int Damage_Per_Level, bool Damage_Over_Time)
		{

			this.Skill_Name = Skill_Name;
			this.Skill_Bonus_Stats = Skill_Bonus_Stats;
			this.Damage_Type = Damage_Type;
			this.Base_Damage = Base_Damage;
			this.Damage_Per_Level = Damage_Per_Level;
			this.Damage_Over_Time = Damage_Over_Time;

		}


		public Skills(string Skill_Name, Stats Skill_Bonus_Stats, string Damage_Type, int Base_Damage, int Damage_Per_Level, 
			bool Damage_Over_Time, Dictionary<string, int> Damage_Scale)
		{

			this.Skill_Name = Skill_Name;
			this.Skill_Bonus_Stats = Skill_Bonus_Stats;
			this.Damage_Type = Damage_Type;
			this.Base_Damage = Base_Damage;
			this.Damage_Per_Level = Damage_Per_Level;
			this.Damage_Over_Time = Damage_Over_Time;
			this.Damage_Scale = Damage_Scale;

		}

		public Skills(string Skill_Name, Stats Skill_Bonus_Stats, string Damage_Type, int Base_Damage, int Damage_Per_Level,
			bool Damage_Over_Time, List<object> Extra_Effects)
		{

			this.Skill_Name = Skill_Name;
			this.Skill_Bonus_Stats = Skill_Bonus_Stats;
			this.Damage_Type = Damage_Type;
			this.Base_Damage = Base_Damage;
			this.Damage_Per_Level = Damage_Per_Level;
			this.Damage_Over_Time = Damage_Over_Time;
			this.Extra_Effects = Extra_Effects;

		}

		public Skills(string Skill_Name, Stats Skill_Bonus_Stats, string Damage_Type, int Base_Damage, int Damage_Per_Level,
			bool Damage_Over_Time, Dictionary<string, int> Damage_Scale, List<object> Extra_Effects)
		{

			this.Skill_Name = Skill_Name;
			this.Skill_Bonus_Stats = Skill_Bonus_Stats;
			this.Damage_Type = Damage_Type;
			this.Base_Damage = Base_Damage;
			this.Damage_Per_Level = Damage_Per_Level;
			this.Damage_Over_Time = Damage_Over_Time;
			this.Damage_Scale = Damage_Scale;
			this.Extra_Effects = Extra_Effects;

		}

	}
    


    public class Item : Stats
    {
		string Item_Name;
		int Cost;
		string Item_Icon_Path;
		string Obtain_Criteria;
		List<object> Passives;
		List<object> Unique_Passives;
		
		

		public Item(string Item_Name, int Cost, string Item_Icon_Path, Stats Item_Stats)
        {

			this.Item_Name = Item_Name;
			this.Cost = Cost;
			this.Item_Image_Path = Item_Image_Path;
			this.Attack_Damage = Item_Stats.Attack_Damage;

		}



    }



    public class Champion : Stats
    {

		string Champion_Name;
		string Champion_Icon_Path;
		List<Skills> Champion_Skills;

        public Champion()
        {

        }

    }



}