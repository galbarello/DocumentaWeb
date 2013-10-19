using System;
using System.Collections.Generic;

namespace Documenta.Infraestructure
{
	public interface IEventStore
	{
		void SaveEvents(Guid aggregateId, IEnumerable<Event> events, int expectedVersion);
		List<Event> GetEventsForAggregate(Guid aggregateId);
	}
}