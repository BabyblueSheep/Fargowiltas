using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fargowiltas.Items.Enchantments
{
	public class BeeEnchant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Enchantment");
			Tooltip.SetDefault("'According to all known laws of aviation, there is no way a bee should be able to fly' \n5% increased minion damage \nIncreases the strength of friendly bees \nSummon damage has a chance to spawn additional bees");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;			
			ItemID.Sets.ItemNoGravity[item.type] = true;
			item.rare = 3; 
			item.value = 20000; 
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			modPlayer.beeEnchant = true;
			
			player.minionDamage += 0.05f;
			player.strongBees = true;  	
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeHeadgear);
			recipe.AddIngredient(ItemID.BeeBreastplate);
			recipe.AddIngredient(ItemID.BeeGreaves);
			recipe.AddIngredient(ItemID.HiveBackpack);
			recipe.AddIngredient(ItemID.Nectar);
			recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}	
}
		
