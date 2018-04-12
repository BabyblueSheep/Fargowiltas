using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fargowiltas.Items.Enchantments
{
	public class FossilEnchant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fossil Enchantment");
			Tooltip.SetDefault("'Beyond a forgotten age' \n" +
								"5% increased throwing damage and velocity \n" +
								"You cheat death, returning with 20 HP \n" +
								"5 minute cooldown\n" +
								"Summons a pet Baby Dino");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;			
			ItemID.Sets.ItemNoGravity[item.type] = true;
			item.rare = 1; 
			item.value = 20000; 
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			modPlayer.fossilEnchant = true;
			
			player.thrownVelocity += 0.05f;
			player.thrownDamage += 0.05f;
			
			//pet
			if (player.whoAmI == Main.myPlayer)
            {
				if(Soulcheck.dinoPet)
				{
					modPlayer.dinoPet = true;
					
					if(player.FindBuffIndex(61) == -1)
					{
						if (player.ownedProjectileCounts[ProjectileID.BabyDino] < 1)
						{
							Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, -1f, ProjectileID.BabyDino, 0, 2f, Main.myPlayer, 0f, 0f);
						}
					}
				}
				else
				{
					modPlayer.dinoPet = false;
				}
			}
			
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FossilHelm);
            recipe.AddIngredient(ItemID.FossilShirt);
			recipe.AddIngredient(ItemID.FossilPants);
			recipe.AddIngredient(ItemID.BoneJavelin, 100);
			recipe.AddIngredient(ItemID.SecretoftheSands);
			recipe.AddIngredient(ItemID.AmberMosquito);
			
			recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
		
