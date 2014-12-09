using System;

namespace Carsharing
{
	public class UserInterfaceFactory
	{
		static public IUi createInterface(string ui)
		{
			IUi interfaceSelection = null;

			switch (ui)
			{
				case "TUI":
				interfaceSelection = new Tui();
				break;
				case "GUI":
				interfaceSelection = new Form1();
				break;
				default:
				throw new Exception("kein gueltiges Interface angegeben");
				break;
			}

			return interfaceSelection;
		}
	}
}

	