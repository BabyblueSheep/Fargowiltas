﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Weapons
{
	public class HentaiSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Penetrator");
			Tooltip.SetDefault("'The reward from slaughtering many..'");
		}

		public override void SetDefaults()
		{
			item.damage = 300;
			item.useStyle = 5;
			item.useAnimation = 16;
			item.useTime = 16;
			item.shootSpeed = 3.7f;
			item.knockBack = 4f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot =  mod.ProjectileType("HentaiSpear");
			item.value = 1000;
			item.noMelee = true; // Important because the spear is acutally a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.melee = true;
			item.autoReuse = true; 
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1; // This is to ensure the spear doesn't bug out when using autoReuse = true
		}
		
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Terraria.Projectile.NewProjectile(position.X, position.Y, speedX, speedY, item.shoot, damage, knockBack, item.owner);
			Terraria.Projectile.NewProjectile(position.X, position.Y, speedX * 5f, speedY * 5f, mod.ProjectileType("Dash"), damage, knockBack, item.owner);
			return false;
		}
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			
			recipe.AddIngredient(null, "EnergizerMoon");
			
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}