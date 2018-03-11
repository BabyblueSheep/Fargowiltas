using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Atrophied : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Atrophied");
			Description.SetDefault("Your muscles are deteriorating.");
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
			//melee silence hopefully plus damage reduced 99%, -all crit just in case
			player.GetModPlayer<FargoPlayer>(mod).atrophied = true;
        }
	}
}
