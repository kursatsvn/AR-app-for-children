using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yanlısbildin1 : MonoBehaviour
{
    public GameObject aktifOlacakObj; // Aktif olacak GameObject'i buradan atayın

    public void yanlısbildinsonrakisoru()
    {
        aktifOlacakObj.SetActive(true); // GameObject'i aktif hale getir
        Invoke("SahneGecisiniYap", 3f); // 5 saniye sonra SahneGecisiniYap fonksiyonunu çağır
    }

    private void SahneGecisiniYap()
    {
        SceneManager.LoadScene(11); // İstediğiniz sahneye geçiş yapın
    }
}
