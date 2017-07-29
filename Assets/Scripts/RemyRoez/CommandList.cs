using System.Collections.Generic;
using UnityEngine.Events;

namespace RemyRoez
{
	[System.Serializable]
	public class CommandEvent : UnityEvent<int, float>
	{
	}

	[System.Serializable]
	public class Command
	{
		public int index;
		public float power;
	}

	[System.Serializable]
	public class CommandSet
	{
		public List<Command> commands;
		
		public void Invoke(CommandEvent commandEvent)
		{
			foreach (Command command in commands)
			{
				commandEvent.Invoke(command.index, command.power);
			}
		}
	}

	public class CommandList : Detail.ListComponent<CommandSet>
	{
		public CommandEvent commandEvent;
	}
}
