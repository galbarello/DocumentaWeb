using System;
using Documenta.Infraestructure;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace Documenta.Tests
{

	public class SpecificationInfo
	{
		public string GroupName;
		public string CaseName;
		public Event[] Given;
		public Command When;
		public Event[] Then;
	}
	
}
