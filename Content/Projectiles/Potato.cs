using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.Audio;
using Terraria.ID;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace purgatorrariamod.Content.Projectiles
{
	public class Potato : ModProjectile
	{
		public override void SetDefaults() {
			Projectile.width = 12; // Hitbox width of projectile
			Projectile.height = 12; // Hitbox height of projectile
			Projectile.friendly = true; // Projectile hits enemies
			Projectile.timeLeft = 10000; // Time it takes for projectile to expire
			Projectile.tileCollide = true; // Projectile collides with tiles
			Projectile.DamageType = DamageClass.Melee; // Projectile is a melee projectile
            Projectile.aiStyle = 2; // Projectile acts like a thrown weapon (shuriken, throwing knife, etc.)
		}

        // Projectile rotates
		public override void AI() 
        {
            Projectile.rotation += (float)Projectile.direction * 0.1f;
        }
	}
}