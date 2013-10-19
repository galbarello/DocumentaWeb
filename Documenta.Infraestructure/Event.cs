using System;

namespace Documenta.Infraestructure
{
	[Serializable]
	public abstract class Event:Message
	{
		public int Version;
	}
}

