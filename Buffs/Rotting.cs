using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Fargowiltas.NPCs;

namespace Fargowiltas.Buffs
{
	public class Rotting : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Rotting");
			Description.SetDefault("Your body is wasting away.");
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
			//inflicts DOT (8 per second) and almost every stat reduced (move speed and use time by 25%)
			player.GetModPlayer<FargoPlayer>(mod).rotting = true;

			player.statLifeMax2 -= player.statLifeMax / 5;
			player.statDefense -= 10;
			player.endurance -= 10;

            if(player.statDefense < 0)
            {
                player.statDefense = 0;
            }
            if(player.endurance < 0)
            {
                player.endurance = 0;
            }

			player.meleeDamage -= 0.1f;
			player.magicDamage -= 0.1f;
			player.rangedDamage -= 0.1f;
			player.thrownDamage -= 0.1f;
			player.minionDamage -= 0.1f;
        }

		public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<FargoGlobalNPC>(mod).rotting = true;
        }
	}
}
