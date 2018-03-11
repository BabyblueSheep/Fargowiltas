using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Weapons
{
	public class PandoraTwo : ModItem
	{		
	public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pandora's Tome");
			Tooltip.SetDefault("A true mess of projectiles");
		}
		public override void SetDefaults()
		{   
            item.damage = 121;                        
            item.magic = true;                    
            item.width = 24;
            item.height = 28;
            item.useTime = 5;
            item.useAnimation = 10;
            item.useStyle = 5;        
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = 1000;
            item.rare = 10;
            item.mana = 12;  //           
            item.UseSound = SoundID.Item21;    //
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 18f;   
		}
		
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{	

		int i = Main.myPlayer;
		float num72 = item.shootSpeed;
		int num73 = item.damage;
		float num74 = item.knockBack;
    	num74 = player.GetWeaponKnockback(item, num74);
    	player.itemTime = item.useTime;
    	Vector2 vector2 = player.RotatedRelativePoint(player.MountedCenter, true);
		Vector2 value = Vector2.UnitX.RotatedBy((double)player.fullRotation, default(Vector2));
		Vector2 vector3 = Main.MouseWorld - vector2;
    	float num78 = (float)Main.mouseX + Main.screenPosition.X - vector2.X;
		float num79 = (float)Main.mouseY + Main.screenPosition.Y - vector2.Y;
		if (player.gravDir == -1f)
		{
			num79 = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY - vector2.Y;
		}
		float num80 = (float)Math.Sqrt((double)(num78 * num78 + num79 * num79));
		float num81 = num80;
		if ((float.IsNaN(num78) && float.IsNaN(num79)) || (num78 == 0f && num79 == 0f))
		{
			num78 = (float)player.direction;
			num79 = 0f;
			num80 = num72;
		}
		else
		{
			num80 = num72 / num80;
		}
    	num78 *= num80;
		num79 *= num80;
		int num146 = 4;
		if (Main.rand.Next(2) == 0)
		{
			num146++;
		}
		if (Main.rand.Next(4) == 0)
		{
			num146++;
		}
		if (Main.rand.Next(8) == 0)
		{
			num146++;
		}
		if (Main.rand.Next(16) == 0)
		{
			num146++;
		}
		for (int num147 = 0; num147 < num146; num147++)
		{
			int r = 0;
			
			do
			{
				
			r = Main.rand.Next(714);
			
			}while(r != 15 && r != 27 && r != 45 && r != 88 && r != 89 && r != 95 && r != 114 && r != 116 && r != 132 && r != 156 && r != 157 && r != 172 && r != 173 && r != 189 && r != 207 && r != 225 && r != 242 && r != 253 && r != 254 && r != 261 && r != 263 && r != 270 && r != 274 && r != 304 && r != 306 && r != 311 && r != 321 && r != 343 && r != 356 && r != 357 && r != 399 && r != 408 && r != 409 && r != 410 && r != 424 && r != 442 && r != 444 && r != 451 && r != 461 && r != 483 && r != 502 && r != 503 && r != 510 && r != 521 && r != 523 && r != 615 && r != 617 && r != 630 && r != 636 && r != 639 && r != 684 && r != 700 && r != 706 && !((r >= 76) && (r <= 78)) && !((r >= 119) && (r <= 126)) && !((r >= 278) && (r <= 280)) && !((r >= 282) && (r <= 285)) && !((r >= 294) && (r <= 295)) && !((r >= 335) && (r <= 338)) && !((r >= 477) && (r <= 479)) && !((r >= 495) && (r <= 497)) && !((r >= 659) && (r <= 661)) && !((r >= 710) && (r <= 712)));
			
			float num148 = num78;
			float num149 = num79;
			float num150 = 0.05f * (float)num147;
			num148 += (float)Main.rand.Next(-35, 36) * num150;
			num149 += (float)Main.rand.Next(-35, 36) * num150;
			num80 = (float)Math.Sqrt((double)(num148 * num148 + num149 * num149));
			num80 = num72 / num80;
			num148 *= num80;
			num149 *= num80;
			float x4 = vector2.X;
			float y4 = vector2.Y;
			
			Projectile.NewProjectile(x4, y4, num148, num149, (r), num73, num74, i, 0f, 0f);
		}
		return false;
			
	}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PandorasBox");
			recipe.AddTile(null, "CrucibleCosmosSheet");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
