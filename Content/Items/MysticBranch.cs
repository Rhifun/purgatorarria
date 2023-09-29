using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using purgatorrariamod.Content.Rarities;

namespace purgatorrariamod.Content.Items
{
	public class MysticBranch : ModItem
	{
		public override void SetStaticDefaults() {

			ItemID.Sets.ItemIconPulse[Item.type] = true; // The item pulses while in the player's inventory
			ItemID.Sets.ItemNoGravity[Item.type] = true; // Makes the item have no gravity

			Item.ResearchUnlockCount = 25; // Configure the amount of this item that's needed to research it in Journey mode.
		}

		public override void SetDefaults() {
			Item.width = 18; // Item weight
			Item.height = 18; // Item height
			Item.maxStack = Item.CommonMaxStack; // Makes the max item stack = global max item stack
			Item.value = 1000; // Makes the item worth 1 gold.
			Item.rare = ModContent.RarityType<BranchRarity>(); // Implements custom rarity
		}

		public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale); // Makes this item glow when thrown out of inventory.
		}

		// Craft 1 dirt block into 25 of these at a workbench for testing purposes
		public override void AddRecipes() {
			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.MysticBranch>(), 25);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

		// Add funny tooltip
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
			var line = new TooltipLine(Mod, "Face", "gaming") {
				OverrideColor = new Color(150, 150, 230)
			};
			tooltips.Add(line);
		}
	}
}