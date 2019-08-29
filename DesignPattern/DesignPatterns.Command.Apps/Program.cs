using System;
using DesignPattern.Repository.Command;

namespace DesignPatterns.Command.Apps
{
	class Program
	{
		static void Main(string[] args)
		{
			//命令模式
			/*（1）降低了系统的耦合度 => 请求发送者与接受者不存在直接引用
　　		   （2）方便地增加新的命令到系统中 => 无须修改源代码，从而符合开闭原则*/
			var button = new Button(new OpenFileCommand());
			button.Click();

			Console.ReadLine();
		}
	}
}
