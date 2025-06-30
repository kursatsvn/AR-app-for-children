using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenilevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string levelName;

    public void OnMouseDown()
    {
        base.transform.localScale = new Vector3(0.9f, 0.9f, 1f);
    }

    public void OnMouseUp()
    {
        base.transform.localScale = new Vector3(1f, 1f, 1f);
        SceneManager.LoadScene(2);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    private void OnMouseClick()
    {
        // Mouse Down ve Mouse Up olaylar�n� tek bir void fonksiyon i�inde birle�tirme
        Debug.Log("Mouse Click");
        // Di�er i�lemler
    }
}
