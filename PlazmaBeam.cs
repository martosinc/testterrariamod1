using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace PlazmaMode.Projectiles
{

    public class PlazmaBeam : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 2; //sprite is 2 pixels wide
            projectile.height = 20; //sprite is 20 pixels tall
            projectile.aiStyle = 0; //projectile moves in a straight line
            projectile.friendly  = true; //player projectile
            projectile.timeLeft = 1200; //lasts for 600 frames/ticks. Terraria runs at 60FPS, so it lasts 10 seconds.
            projectile.melee = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(39, 660); //The debuff inflicted is the modded debuff Ethereal Flames. 180 is the duration in frames: Terraria runs at 60 FPS, so that's 3 seconds (180/60=3). To change the modded debuff, change EtherealFlames to whatever the buff is called; to add a vanilla debuff, change mod.BuffType("EtherealFlames") to a number based on the terraria buff IDs. Some useful ones are 20 for poison, 24 for On Fire!, 39 for Cursed Flames, 69 for Ichor, and 70 for Venom.
        }
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation();
        }
        public void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(projectile.position, 0.9f, 0.45f, 0.45f);
        }
    }
}