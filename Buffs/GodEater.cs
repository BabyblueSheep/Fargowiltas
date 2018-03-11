using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class GodEater : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("God Eater");
			Description.SetDefault("Your soul is cursed by divine wrath.");
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
           //defense removed, endurance removed, colossal DOT (45 per second)
		   player.GetModPlayer<FargoPlayer>(mod).godEater = true;
        }
	}
}
