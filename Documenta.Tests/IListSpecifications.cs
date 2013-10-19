using System;
using Documenta.Infraestructure;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace Documenta.Tests
{

	public interface IListSpecifications
	{
		IEnumerable<SpecificationInfo> ListSpecifications();
	}
	
}
