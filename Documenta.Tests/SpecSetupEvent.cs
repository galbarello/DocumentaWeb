using System;
using Documenta.Infraestructure;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace Documenta.Tests
{

	/// <summary>
	/// Helper event, which allows us to turn test domain services into light-weight
	/// event-sourced classes
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class SpecSetupEvent : Event, IAmFakeEventForTesting 
	{
		public string FakeType { get { return null; } }

		readonly string _describe;
		public readonly Action Apply;

		public SpecSetupEvent(Action apply, string describe, params object[] args)
		{
			Apply = apply;
			_describe = string.Format(describe, args);
		}
		public override string ToString()
		{
			return _describe;
		}
	}

}
