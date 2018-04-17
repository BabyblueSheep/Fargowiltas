using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Weapons
{
	public class GuardianTome : ModItem
	{		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Guardian");
			Tooltip.SetDefault("'It's their turn to run'");
		}
		public override void SetDefaults()
		{   
            item.damage = 999;                        
            item.magic = true;                    
            item.width = 24;
            item.height = 28;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;        
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = 1000;
            item.rare = 10;//
            item.mana = 100;  //           
            item.UseSound = SoundID.Item21;    //
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("DungeonGuardian");
            item.shootSpeed = 18f;    //projectile speed when shoot
			
			
		}
		
		
		
	}
}
