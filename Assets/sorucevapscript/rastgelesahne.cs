using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rastgelesahne : MonoBehaviour
{
   
    public string[] sahneIsimleri; // Sahne isimlerini bu diziye atay�n

    public void ButonaBasildiginda()
    {
        if (sahneIsimleri.Length > 0)
        {
            // Rastgele bir sahne ismi se�
            string rastgeleSahneIsimi = sahneIsimleri[Random.Range(0, sahneIsimleri.Length)];

            // Se�ilen sahneyi y�kle
            SceneManager.LoadScene(rastgeleSahneIsimi);
        }
        else
        {
            Debug.LogError("Sahne isimleri belirtilmemi�!");
        }
    }
}


