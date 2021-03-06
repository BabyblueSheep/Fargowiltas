using Terraria.ID;

namespace Fargowiltas.Items.Summons.Deviantt
{
    public class SlimyLockBox : BaseSummon
    {
        public override int Type => NPCID.DungeonSlime;

        public override string NPCName => "Dungeon Slime";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Lock Box");
            Tooltip.SetDefault("Summons Dungeon Slime");
        }
    }
}