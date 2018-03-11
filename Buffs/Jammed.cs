using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Jammed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Jammed");
			Description.SetDefault("Your ranged weapons are faulty.");
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
			//all ranged weapons shoot confetti 
			player.GetModPlayer<FargoPlayer>(mod).jammed = true;
        }
	}
}
