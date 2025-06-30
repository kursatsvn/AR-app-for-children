using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yanlis5 : MonoBehaviour
{
    public GameObject aktifOlacakObj; // Aktif olacak GameObject'i buradan atay�n

    public void yanlısbildinsonrakisoru()
    {
        aktifOlacakObj.SetActive(true); // GameObject'i aktif hale getir
        Invoke("SahneGecisiniYap", 3f); // 5 saniye sonra SahneGecisiniYap fonksiyonunu �a��r
    }

    private void SahneGecisiniYap()
    {
        SceneManager.LoadScene(15); // �stedi�iniz sahneye ge�i� yap�n
    }
}
