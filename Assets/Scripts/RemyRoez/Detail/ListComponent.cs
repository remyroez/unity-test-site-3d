using System.Collections.Generic;
using UnityEngine;

namespace RemyRoez.Detail
{
	public abstract class ListComponent<T> : MonoBehaviour
	{
		public List<T> list;
		
		public T this[int index]
		{
			get
			{
				return list[index];
			}

			set
			{
				list[index] = value;
			}
		}

		public int Count
		{
			get
			{
				return list.Count;
			}
		}
	}
}
