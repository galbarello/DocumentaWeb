using System;

namespace Documenta.Infraestructure.Storage
{
	public class MongoStore:IEventStore
	{
		#region IEventStore implementation

		public void SaveEvents (Guid aggregateId, System.Collections.Generic.IEnumerable<Event> events, int expectedVersion)
		{
			throw new NotImplementedException ();
		}

		public System.Collections.Generic.List<Event> GetEventsForAggregate (Guid aggregateId)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

