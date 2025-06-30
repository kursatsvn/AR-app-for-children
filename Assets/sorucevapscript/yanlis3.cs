using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yanlis3 : MonoBehaviour
{
    public GameObject aktifOlacakObj; // Aktif olacak GameObject'i buradan atayýn

    public void yanlýsbildinsonrakisoru()
    {
        aktifOlacakObj.SetActive(true); // GameObject'i aktif hale getir
        Invoke("SahneGecisiniYap", 3f); // 5 saniye sonra SahneGecisiniYap fonksiyonunu çaðýr
    }

    private void SahneGecisiniYap()
    {
        SceneManager.LoadScene(13); // Ýstediðiniz sahneye geçiþ yapýn
    }

}
