using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Hexed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hexed");
			Description.SetDefault("Your attacks heal enemies.");
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
            player.GetModPlayer<FargoPlayer>().hexed = true;
        }

    }
}