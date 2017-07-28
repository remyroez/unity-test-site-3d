using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCommand : MonoBehaviour {

	public string message = "Hello, World!";

	public void Execute()
	{
		Debug.Log(message);
	}
}
