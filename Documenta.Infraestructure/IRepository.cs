using System;

namespace Documenta.Infraestructure
{
	public interface IRepository<T> where T : AggregateRoot, new()
	{
		void Save(AggregateRoot aggregate, int expectedVersion);
		T GetById(Guid id);
	}
}

