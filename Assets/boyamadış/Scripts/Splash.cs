/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
	public int levelNum;

	private float life = 1.5f;

	private void Awake()
	{
		Camera.main.aspect = 1.6f;
		Screen.sleepTimeout = -1;
	}

	private void Update()
	{
		life -= Time.deltaTime;
		Color color = GetComponent<Renderer>().material.GetColor("_Color");
		GetComponent<Renderer>().material.SetColor("_Color", new Color(color.r, color.g, color.g, life));
		if (life < 0f)
		{
			SceneManager.LoadScene(levelNum);
		}
	}
}
