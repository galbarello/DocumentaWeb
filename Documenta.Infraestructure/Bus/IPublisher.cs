using System;

namespace Documenta.Infraestructure.Bus
{
	public interface IPublisher
	{
		void Publish<T>(T @event) where T : Event;
	}
}

