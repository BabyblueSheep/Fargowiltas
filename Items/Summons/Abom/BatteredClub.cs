using Terraria.ID;

namespace Fargowiltas.Items.Summons.Abom
{
    public class BatteredClub : BaseSummon
    {
        public override int Type => NPCID.DD2OgreT2;

        public override string NPCName => "Ogre";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Battered Club");
            Tooltip.SetDefault("Summons the Ogre");
        }
    }
}