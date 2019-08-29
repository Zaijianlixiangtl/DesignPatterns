using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Command
{
	public class Button 
	{
		private readonly Command command;

		public Button(Command command)
		{
			this.command = command;
		}

		public void Click()
		{
			if (command != null)
			{
				command.Execute();
			}
		}
	}
}
