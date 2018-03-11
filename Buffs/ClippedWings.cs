using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class ClippedWings : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Clipped Wings");
			Description.SetDefault("You cannot fly or use rocket boots.");
			Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            canBeCleared = true;
		}
		
		public override bool Autoload(ref string name, ref string texture)
        {
            texture = "Fargowiltas/Buffs/PlaceholderDebuff";

            return true;
        }

		public override void Update(Player player, ref int buffIndex)
        {
		   player.wingTime = 0;
		   player.wingTimeMax = 0;
           player.rocketTime = 0;
        }
	}
}
