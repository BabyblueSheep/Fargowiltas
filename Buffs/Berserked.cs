using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Berserked : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Berserked");
			Description.SetDefault("You cannot control yourself.");
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
            //causes player to constantly use weapon
            //seemed to have strange interactions with stunning debuffs like frozen or stoned...
            player.HeldItem.autoReuse = true;
			player.controlUseItem = true;
			player.releaseUseItem = true;
        }
	}
}
