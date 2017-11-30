using Terraria.ModLoader;

namespace JMP
{
	class JMP : Mod
	{
		public JMP()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
