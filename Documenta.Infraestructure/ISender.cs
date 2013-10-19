using System;

namespace Documenta.Infraestructure
{
	public interface ISender
	{
		void Send<T>(T command) where T : Command;

	}
}

