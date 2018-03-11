using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fargowiltas.Items.Enchantments
{
	public class IronEnchant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Enchantment");
			Tooltip.SetDefault("'Nice magnetic field' \n"+ //why
								"You attract items from a much larger range");
		}
		public override void SetDefaults()
		{
			item.defense = 1;
			item.width = 20;
			item.height = 20;
			item.accessory = true;			
			ItemID.Sets.ItemNoGravity[item.type] = true;
			item.rare = 0; //
			item.value = 10000; 
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			modPlayer.ironEnchant = true;
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			
			recipe.AddIngredient(ItemID.IronHelmet);
			recipe.AddIngredient(ItemID.IronChainmail);
			recipe.AddIngredient(ItemID.IronGreaves);
			recipe.AddIngredient(ItemID.IronBroadsword);
			
			recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
		
