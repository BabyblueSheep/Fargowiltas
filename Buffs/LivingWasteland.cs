using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class LivingWasteland : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Living Wasteland");
			Description.SetDefault("Everyone around you turns to rot.");
			Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            canBeCleared = false;
		}
		
		public override bool Autoload(ref string name, ref string texture)
        {
            texture = "Fargowiltas/Buffs/PlaceholderDebuff";

            return true;
        }

		public override void Update(Player player, ref int buffIndex)
        {
			//inflicts rotting on everything in range
			if(player.ownedProjectileCounts[mod.ProjectileType("DeathAura")] <= 0 && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("DeathAura"), 9001, 9f, player.whoAmI);
				player.ownedProjectileCounts[mod.ProjectileType("DeathAura")]++;
			}
			
			player.GetModPlayer<FargoPlayer>(mod).rotting = true;
        }
	}
}
