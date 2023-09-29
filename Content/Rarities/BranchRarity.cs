using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace purgatorrariamod.Content.Rarities
{
	public class BranchRarity : ModRarity
	{
		public override Color RarityColor => new Color((200 + (Main.DiscoR/5)), (200 + (Main.DiscoG/5)), 120);
        // 250 200 120  ->  200 250 120
        // Cycles between the colors above (light orange -> light green)
	}
}