using System;

namespace Documenta.Infraestructure
{
	public interface IPublisher
	{
		void Publish<T>(T @event) where T : Event;
	}
}

