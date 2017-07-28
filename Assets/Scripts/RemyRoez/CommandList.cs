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
		public CommandEvent commandEvent;

		public void Invoke()
		{
			commandEvent.Invoke(index, power);
		}
	}

	[System.Serializable]
	public class Commands
	{
		public List<Command> list;


		public void Invoke()
		{
			foreach (Command command in list)
			{
				command.Invoke();
			}
		}
	}

	public class CommandList : Detail.ListComponent<Commands>
	{
	}
}
