using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RemyRoez
{

	[RequireComponent(typeof(Camera))]
	public class FollowCamera : MonoBehaviour
	{
		public Transform target;

		// カメラコンポーネント
		private Camera _camera;
		private new Camera camera
		{
			get
			{
				return (_camera != null) ? _camera : (_camera = GetComponent<Camera>());
			}
		}

		// Update is called once per frame
		void Update()
		{
			if (target == null) return;

			camera.transform.LookAt(target);
		}
	}

}