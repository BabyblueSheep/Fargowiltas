using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Fused : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Fused");
			Description.SetDefault("A bomb is gonna go off soon in you...");
			Main.buffNoSave[Type] = true;
			canBeCleared = true;
			Main.debuff[Type] = true;
		}

        public override bool Autoload(ref string name, ref string texture)
        {
            texture = "Fargowiltas/Buffs/PlaceholderDebuff";

            return true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<FargoPlayer>().fused = true;

            if (player.buffTime[buffIndex] < 3)
            {
                Projectile.NewProjectile(player.position, player.velocity * 0, mod.ProjectileType("FusionBomb"), 150, 4f);
                //Projectile proj = Projectile.NewProjectileDirect(player.Center, player.velocity * 0, mod.ProjectileType("BoomShuriken"), 150, 4f);
                //proj.Kill();
            }
        }

        public override bool ReApply(Player player, int time, int buffIndex)
        {
            return true;
        }

    }
}