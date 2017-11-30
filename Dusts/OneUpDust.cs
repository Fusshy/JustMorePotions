using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JMP.Dusts
{
	public class OneUpDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.frame = new Rectangle(0, 0, 24, 22);
			dust.velocity.Y = 0f;
			dust.velocity.X = 0f;
			dust.noGravity = false;
			dust.noLight = true;
			dust.scale *= 1f;
		}

		public override bool Update(Dust dust)
		{
			dust.scale *= 1.02f;
			float light = 0.1f * dust.scale;
			Lighting.AddLight(dust.position, light, light, light);
			if (dust.scale > 12f)
			{
				dust.active = false;
			}
			return false;
		}
	}
}