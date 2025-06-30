using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yanlıs6 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aktifOlacakObj; // Aktif olacak GameObject'i buradan atay�n

    public void yanlısbildinsonrakisoru()
    {
        aktifOlacakObj.SetActive(true); // GameObject'i aktif hale getir
        Invoke("SahneGecisiniYap", 3f); // 5 saniye sonra SahneGecisiniYap fonksiyonunu �a��r
    }

    private void SahneGecisiniYap()
    {
        SceneManager.LoadScene(16); // �stedi�iniz sahneye ge�i� yap�n
    }
}
