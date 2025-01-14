using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Macrocosm.Content.Dusts {
    public class CrucibleDust : ModDust {
        public override void OnSpawn(Dust dust) {
            dust.scale *= 1f;
        }

        public override bool MidUpdate(Dust dust) {
            dust.rotation += dust.velocity.X / 3f;
            
            if (!dust.noLight) {
                float strength = dust.scale * 1.4f;
                if (strength > 1f) {
                    strength = 1f;
                }
                Lighting.AddLight(dust.position, 0.7f * strength, 0.3f * strength, 0.1f * strength);
            }
            return true;
            // if (Collision.SolidCollision(dust.position + dust.velocity, 10, 10) && dust.fadeIn == 0f) {
            //     dust.scale *= 0.9f;
            //     dust.velocity *= 0.10f;
            // }
            // return false;
        }

        public override Color? GetAlpha(Dust dust, Color lightColor) {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 25);
        }
    }
}