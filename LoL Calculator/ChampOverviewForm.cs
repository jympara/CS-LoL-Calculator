﻿using System;
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
	public partial class ChampOverviewForm : Form
	{
		public string DrawBaseStats;

		public static class ChampInfoHolder
		{
			public static string Name = "";
			public static Image Icon = new Bitmap(70,70);
			public static Stats BaseStats = new Stats();
			public static Stats StatsPerLevel = new Stats();
			public static Stats BonusStats = new Stats();
			public static Stats TotalStats = new Stats();
			public static int Level = 1;
			public static string Resource = "";
		}


		public SortedList<int, Item> CurrentInventory = new SortedList<int, Item>(6);

		public List<PictureBox> InventoryBoxes = new List<PictureBox>(6);

		public void LoadInvBoxes()
		{
			InventoryBoxes.Add(itemBox1);
			InventoryBoxes.Add(itemBox2);
			InventoryBoxes.Add(itemBox3);
			InventoryBoxes.Add(itemBox4);
			InventoryBoxes.Add(itemBox5);
			InventoryBoxes.Add(itemBox6);
		}
		

		public ChampOverviewForm()
		{
			InitializeComponent();
		}

		private void ChampOverviewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.UnMinimizeMainMenu();
		}

		private void ChampOverviewForm_Load(object sender, EventArgs e)
		{
			Image Icon;
			String Name;

			foreach (var item in Data.ChampionList)
			{
				Icon = (Bitmap)(item.Value["Icon"]);
				Name = item.Key;
				ChampSelectList.Items.Add(Name, Icon);
			}

			foreach (var item in Data.ItemList)
			{
				Icon = (Bitmap)(item.Value.Icon);
				Name = item.Key;
				ItemSelectList.Items.Add(Name, Icon);
			}

			ChampSelectList_ItemClicked(0, new ToolStripItemClickedEventArgs(ChampSelectList.Items[0]));
			GetCurrentChampInfo();
			LoadInvBoxes();
		}


		public string GetToolTipForItems(string ItemName)
		{
			string ToolTipText = "";
			ToolTipText += ItemName + $"\r\n";
			if (Data.ItemList[ItemName].Stats.AD != 0)
				ToolTipText += "AD + " + Data.ItemList[ItemName].Stats.AD + $"\r\n";
			if (Data.ItemList[ItemName].Stats.AP != 0)
				ToolTipText += "AP + " + Data.ItemList[ItemName].Stats.AP + $"\r\n";
			if (Data.ItemList[ItemName].Stats.AttackSpeed != 0)
				ToolTipText += "Attack Speed + " + Data.ItemList[ItemName].Stats.AttackSpeed + $"\r\n";
			if (Data.ItemList[ItemName].Stats.Lethality != 0)
				ToolTipText += "Lethality + " + Data.ItemList[ItemName].Stats.Lethality + $"\r\n";
			if (Data.ItemList[ItemName].Stats.ArmorPen != 0)
				ToolTipText += "Armor Pen + " + Data.ItemList[ItemName].Stats.ArmorPen + $"\r\n";
			if (Data.ItemList[ItemName].Stats.MagicPen != 0)
				ToolTipText += "Magic Pen + " + Data.ItemList[ItemName].Stats.MagicPen + $"\r\n";
			if (Data.ItemList[ItemName].Stats.MagicPen_percent != 0)
				ToolTipText += "Magic Pen + " + Data.ItemList[ItemName].Stats.MagicPen_percent * 100 + $" %\r\n";
			if (Data.ItemList[ItemName].Stats.HP != 0)
				ToolTipText += "HP + " + Data.ItemList[ItemName].Stats.HP + $"\r\n";
			if (Data.ItemList[ItemName].Stats.HP5 != 0)
				ToolTipText += "HP5 + " + Data.ItemList[ItemName].Stats.HP5 + $"\r\n";
			if (Data.ItemList[ItemName].Stats.MP != 0)
				ToolTipText += "MP + " + Data.ItemList[ItemName].Stats.MP + $"\r\n";
			if (Data.ItemList[ItemName].Stats.MP5 != 0)
				ToolTipText += "MP5 + " + Data.ItemList[ItemName].Stats.MP5 + $"\r\n";
			if (Data.ItemList[ItemName].Stats.Armor != 0)
				ToolTipText += "Armor + " + Data.ItemList[ItemName].Stats.Armor + $"\r\n";
			if (Data.ItemList[ItemName].Stats.MagicRes != 0)
				ToolTipText += "Magic Resist + " + Data.ItemList[ItemName].Stats.MagicRes + $"\r\n";
			if (Data.ItemList[ItemName].Stats.MoveSpeed != 0)
				ToolTipText += "Movement Speed + " + Data.ItemList[ItemName].Stats.MoveSpeed + $"\r\n";
			if (Data.ItemList[ItemName].Stats.Range != 0)
				ToolTipText += "Range + " + Data.ItemList[ItemName].Stats.Range + $"\r\n";/*
			if (Dat    ! ! ! "" "" "" #" #" #" (#% (#% (#% *$& *$& *$& (#$ (#$ (#$ +%& +%& +%& &!# &!# &!# % # % # % #             ! ! ! ! ! !                                           " " "       ) ) )    + + +    * * * # # # # # # * * *  -  -  -  -  -  - CFNCFNCFNCGPCGPCGPCENCENCENCITCITCITKOZKOZKOZGMXGMXGMXKP[KP[KP[KP[KP[KP[UXa(UXa(UXa(VYc(VYc(VYc(UU^(UU^(UU^(MR\MR\MR\<@H<@H<@H<?G<?G<?G9=E9=E9=E:>F:>F:>F! ! ! ' ' ' "$+"$+"$+# # #  .:  .:  .: '19'19'19   #! #! #!             #! #! #!                  PK
         jq"�           sp_hdr_2296.vhv   �'��      }                         �                        �   �                                                                                                                                                                                                                                                                                                                                                                                                                                                  

 

 

       0*- 0*- 0*- *%' *%' *%' +,2 +,2 +,2 % " % " % "       
	 
	 */
	 

 

 

 
	
 
	
 
	
 
 
 
 
	 
	 
	 
	 
	 
	                # # #  %  %  % "" "" "" &"$ &"$ &"$ '"$ '"$ '"$ '"$ '"$ '"$          +&) +&) +&) ,'* ,'* ,'* -,1 -,1 -,1 +(+ +(+ +(+ +)- +)- +)- ,,1 ,,1 ,,1 ,'* ,'* ,'*                   # # # &! &! &! >,+ >,+ >,+ 5(( 5(( 5(( .&( .&( .&( -&( -&( -&( *&) *&) *&)    +'* +'* +'*          /), /), /), 2)+ 2)+ 2)+ 4*+ 4*+ 4*+ ;++ ;++ ;++       $ $ $ 7*+ 7*+ 7*+ # # #             *'+ *'+ *'+ "  "  "       %   %   %       
 
 
 
 
 
 % % % ,+0 ,+0 ,+0 *$& *$& *$& )$& )$& )$& %!# %!# %!#          
 
 
                !!% !!% !!%  #  #  #                                        

 

 

 
 
 
                   $#' $#' $#' &$( &$( &$( !  !  !        $ $ $ %  %  %        ! ! ! ! ! !                   # # #          &$( &$( &$( # " # " # "    ,&' ,&' ,&'    -&& -&& -&&    # # #                         $ $ $          *%) *%) *%) /), /), /), .&) .&) .&) (!" (!" (!" *#% *#% *#% /$% /$% /$% +#$ +#$ +#$ $ $ $    +%& +%& +%& (#$ (#$ (#$ &!# &!# &!# *$% *$% *$% (#$ (#$ (#$ &!# &!# &!#                   $"$ $"$ $"$ -(* -(* -(* 5-. 5-. 5-.    %!" %!" %!" /(( /(( /(( * * * ' ' ' * * * $ $ $                   ! ! ! *,4 *,4 *,4 1.5 1.5 1.5 7,. 7,. 7,. 9-/ 9-/ 9-/ =// =// =// 9,, 9,, 9,, %! %! %!       .(* .(* .(* /(* /(* /(* /)+ /)+ /)+ -') -') -') -') -') -') /(* /(* /(* # # #    %!" %!" %!" /(( /(( /(( -&' -&' -&' 5-. 5-. 5-. ,&' ,&' ,&' -(* -(* -(* # " # " # " $"$ $"$ $"$          %!" %!" %!" ! ! !    % $ % $ % $    ! ! ! $ $ $       $ $ $             +%( +%( +%( 0), 0), 0), 3*, 3*, 3*, 5*, 5*, 5*, <.. <.. <.. 8+, 8+, 8+, *#$ *#$ *#$ $ $ $    +%' +%' +%' +%' +%' +%' *$& *$& *$& *$& *$& *$& )#% )#% )#% )#% )#% )#% & & &    ( ( (       ! ! ! 0)+ 0)+ 0)+ 1*+ 1*+ 1*+ 1*+ 1*+ 1*+ 0)* 0)* 0)* /(* /(* /(* 0)+ 0)+ 0)+ % % %    ( ( (       ! ! !             % % % &-6 &-6 &-6 ,2; ,2; ,2; .), .), .), 1*+ 1*+ 1*+ 3)* 3)* 3)* 1'( 1'( 1'( ! ! !       ,'* ,'* ,'* ,'* ,'* ,'* .,1 .,1 .,1 +(, +(, +(, ,*. ,*. ,*. -,1 -,1 -,1                   /), /), /), 9-/ 9-/ 9-/ -%' -%' -%'                   # # # 4*+ 4*+ 4*+ =00 =00 =00 7*+ 7*+ 7*+ '!" '!" '!" # # #       ! ! ! =// =// =// 7,- 7,- 7,- //6 //6 //6             % " % " % "    0*- 0*- 0*- #! #! #! *%' *%' *%'    +,2 +,2 +,2                   ! ! !    " " " =// =// =// 2() 2() 2() /(* /(* /(* 7,- 7,- 7,- //6 //6 //6 '0: '0: '0:                &$( &$( &$(    +)- +)- +)-                               +(, +(, +(,    ! ! !                   # # #          '&* '&* '&*       # # #    &! &! &!    # # # 5(( 5(( 5((          -&( -&( -&( ,'* ,'* ,'* '&* '&* '&*             
 
 
 

 

 

       #! #! #! %!# %!# %!#       "  "  "              

 

 

 
 
 
 " " "       

 

 

    
 
 
 '0: '0: '0: % % % /(* /(* /(* ,+0 ,+0 ,+0 *$& *$& *$& 2() 2() 2() " " "          $ $ $       *#% *#% *#% 0') 0') 0') 7,- 7,- 7,- ;.0 ;.0 ;.0