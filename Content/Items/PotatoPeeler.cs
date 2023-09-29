using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using purgatorrariamod.Content.Projectiles;

namespace purgatorrariamod.Content.Items
{
	public class PotatoPeeler : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 15; // Base damage
			Item.DamageType = DamageClass.Melee; // Deals melee damage
			Item.width = 40; // Item width
			Item.height = 40; // Item height
			Item.useTime = 35; // Weapon speed
			Item.useAnimation = 25; // Animation speed
			Item.useStyle = 1; // Acts like a sword
			Item.knockBack = 6; // Weapon Knockback
			Item.value = 5000; // Worth 50 silver
			Item.rare = 2; // Green default rarity
			Item.UseSound = SoundID.Item1; // Sword sound
			Item.autoReuse = false; // Not autouse
            Item.shootSpeed = 6.0f; // Potato speed
            Item.shoot = ModContent.ProjectileType<Potato>(); // Shoots the potato
            Item.shootsEveryUse = true; // Shoots every time the sword is swung
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<MysticBranch>();
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			var line = new TooltipLine(Mod, "Face", "gaming") {
				OverrideColor = new Color(150, 150, 2300)
			};
			tooltips.Add(line);
		}
	}
}
