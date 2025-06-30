

using UnityEngine;

public class CameraAspect : MonoBehaviour
{
	public GameObject Music;

	private void Awake()
	{
		Camera.main.aspect = 1.6f;
		Screen.sleepTimeout = -1;
		
	}
}
