using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Command
{
	public class OpenFileCommand : Command
	{
		OpenFileHandle openFileHandle = null;
		public OpenFileCommand()
		{
			openFileHandle = new OpenFileHandle();
		}

		public override void Execute()
		{
			if (openFileHandle != null)
			{
				openFileHandle.OpenFile();
			}
		}
	}
}
