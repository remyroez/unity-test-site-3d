using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RemyRoez
{

	[RequireComponent(typeof(JointList))]
	public class JointCommand : MonoBehaviour
	{

		// ジョイントコンポーネント
		private JointList _jointList;
		private JointList jointList
		{
			get
			{
				return (_jointList != null) ? _jointList : (_jointList = GetComponent<JointList>());
			}
		}

		public void Execute(int index, float power)
		{
			Joint joint = jointList[index];
			if (joint == null) return;

			Rigidbody rigidBody = joint.GetComponent<Rigidbody>();
			if (rigidBody == null) return;
			
			rigidBody.AddForce(rigidBody.transform.forward * power);
		}
	}
}
