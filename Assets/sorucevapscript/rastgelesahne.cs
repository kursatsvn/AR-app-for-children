using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rastgelesahne : MonoBehaviour
{
   
    public string[] sahneIsimleri; // Sahne isimlerini bu diziye atayýn

    public void ButonaBasildiginda()
    {
        if (sahneIsimleri.Length > 0)
        {
            // Rastgele bir sahne ismi seç
            string rastgeleSahneIsimi = sahneIsimleri[Random.Range(0, sahneIsimleri.Length)];

            // Seçilen sahneyi yükle
            SceneManager.LoadScene(rastgeleSahneIsimi);
        }
        else
        {
            Debug.LogError("Sahne isimleri belirtilmemiþ!");
        }
    }
}


