using System;

namespace Documenta.Infraestructure.Bus
{
	public interface ISender
	{
		void Send<T>(T command) where T : Command;

	}
}

