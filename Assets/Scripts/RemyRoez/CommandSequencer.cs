using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RemyRoez
{

	[RequireComponent(typeof(CommandList))]
	public class CommandSequencer : MonoBehaviour
	{
		// 間隔
		public float interval = 0.1f;

		// 経過時間
		private float time;

		// コマンドのカウンター
		private int counter = 0;

		// コマンドリストコンポーネント
		private CommandList _commandList;
		private CommandList commandList
		{
			get
			{
				return (_commandList != null) ? _commandList : (_commandList = GetComponent<CommandList>());
			}
		}

		// Use this for initialization
		void Start()
		{
			ResetTime();
		}

		// Update is called once per frame
		void Update()
		{
			// 時間の経過
			time -= Time.deltaTime;

			// 一定時間経過した
			if (time < 0.0f)
			{
				InvokeCommand(counter);
				ResetTime();

				counter++;

				// 最後までカウントしたら最初から
				if (counter >= commandList.Count)
				{
					counter = 0;
				}
			}
		}

		// 時間のリセット
		private void ResetTime()
		{
			time = interval;
		}

		// コマンドの実行
		private void InvokeCommand(int index)
		{
			commandList[index].Invoke(commandList.commandEvent);
		}
	}

}
