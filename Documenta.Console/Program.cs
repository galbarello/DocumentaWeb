namespace Documenta.Console
{
	using System;
	using Documenta.Infraestructure.Bus;

	class MainClass
	{

		private static readonly IBus _bus = new InMemoryBus ();

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
}
