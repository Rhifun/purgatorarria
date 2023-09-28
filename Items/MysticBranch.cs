using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgatorrariamod.Items
{
	public class MysticBranch : ModItem
	{
		public override void SetStaticDefaults() {

			ItemID.Sets.ItemIconPulse[Item.type] = true; // The item pulses while in the player's inventory
			ItemID.Sets.ItemNoGravity[Item.type] = true; // Makes the item have no gravity

			Item.ResearchUnlockCount = 25; // Configure the amount of this item that's needed to research it in Journey mode.
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.maxStack = Item.CommonMaxStack;
			Item.value = 1000; // Makes the item worth 1 gold.
			Item.rare = ItemRarityID.Orange;
		}

		public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale); // Makes this item glow when thrown out of inventory.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.MysticBranch>(), 25);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips) {
			var line = new TooltipLine(Mod, "Face", "gaming") {
				OverrideColor = Main.DiscoColor
			};
			tooltips.Add(line);
		}
	}
}