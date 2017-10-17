using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class SpookyCD : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Scythe Cooldown");
			Description.SetDefault("No Scythes for a bit");
			Main.buffNoSave[Type] = true;
			canBeCleared = false;
			Main.debuff[Type] = true;
		}

	}
}