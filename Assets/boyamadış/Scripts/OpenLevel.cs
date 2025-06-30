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

public class OpenLevel : MonoBehaviour
{
	public string levelName;

	public void OnMouseDown()
	{
		base.transform.localScale = new Vector3(0.9f, 0.9f, 1f);
	}

	public void OnMouseUp()
	{
		base.transform.localScale = new Vector3(1f, 1f, 1f);
		SceneManager.LoadScene(0);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    private void OnMouseClick()
    {
        // Mouse Down ve Mouse Up olaylarını tek bir void fonksiyon içinde birleştirme
        Debug.Log("Mouse Click");
        // Diğer işlemler
    }
}
