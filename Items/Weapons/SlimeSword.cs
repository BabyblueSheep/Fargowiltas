<<<<<<< HEAD
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Weapons
{
	public class SlimeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Slinging Slasher");
			Tooltip.SetDefault("'The reward from slaughtering many..'");
		}
		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee=true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 50000;
			item.rare = 5;
			item.UseSound = SoundID.Item1; 
			item.autoReuse = true; 
			item.shoot = mod.ProjectileType("SlimeBall");
			item.shootSpeed = 10f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			int numberProjectiles = 4 + Main.rand.Next(5); // 4 to 8 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45)); // 45 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false; 
        }

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Slimed, 180);
		}
		
		public override void AddRecipes()
		{	
			ModRecipe recipe = new ModRecipe(mod);
			
			recipe.AddIngredient(null, "SlimeKingsSlasher");
			recipe.AddIngredient(null, "EnergizerSlime");
			
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
=======
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Weapons
{
	public class SlimeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Slinging Slasher");
			Tooltip.SetDefault("'The reward from slaughtering many..'");
		}
		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee=true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 50000;
			item.rare = 5;
			item.UseSound = SoundID.Item1; 
			item.autoReuse = true; 
			item.shoot = mod.ProjectileType("SlimeBall");
			item.shootSpeed = 10f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			int numberProjectiles = 4 + Main.rand.Next(5); // 4 to 8 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45)); // 45 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false; 
        }

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Slimed, 180);
		}
		
		public override void AddRecipes()
		{	
			ModRecipe recipe = new ModRecipe(mod);
			
			recipe.AddIngredient(null, "SlimeKingsSlasher");
			recipe.AddIngredient(null, "EnergizerSlime");
			
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
>>>>>>> 66ed39caf4938fca8e7009752b635e42f8a8a58f
}