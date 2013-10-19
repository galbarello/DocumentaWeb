using NUnit.Framework;
using System;
using Documenta.Infraestructure.Storage;

namespace Documenta.Tests
{
	[TestFixture]
	public class EventStoreTests
	{
		[Test]
		public void should_be_easy_to_create_a_new_eventStore()
		{
			IEventStore _store = new MongoStore ();
			Assert.IsNotNull (_store);
		}

		[Test]
		public void sould_be_able_to_connect_to_underling_persistence()
		{
			Assert.Fail ();
		} 

	}
}

