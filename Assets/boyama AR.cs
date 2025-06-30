using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boyamaAR : MonoBehaviour
{
    public static boyamaAR instance;
    private string oncekiSahneAdi;
    private bool yokOl = false;
    private bool var = false;
    private bool shouldPersist = false;
    private void Awake()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "boyamagiris")
        {
            // Bu objeyi yok et
            Destroy(this.gameObject);
        }
        else
        {
            // E�er hedef sahne de�ilse, objeyi koruma alt�na al
            DontDestroyOnLoad(this.gameObject);
            shouldPersist = true;
        }
        
    }
    float x = 1.15999997f;
    float y = 0.4f;
    float z = 35.5800018f;
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "anaekran")
        {
            // E�er sahne ad� "anaekran" ise, objeyi yok et
            Destroy(this.gameObject);
        }
        // �u anki sahnenin ad�n� al
        string suankiSahneAdi = SceneManager.GetActiveScene().name;

        // E�er �u anki sahne ad� "IlkSahne" ise ve di�er sahneye ge�iliyorsa
        if (suankiSahneAdi == "3Dmodel")
        {
            // Di�er sahneye ge�ildi�inde objenin pozisyonunu ayarla
            GameObject obje = GameObject.Find("Coloring-Page"); // "ObjeninAdi" objenin ad�n� ve hiyerar�ideki ismini temsil eder
            if (obje != null)
            {
                // Objeyi yeni bir pozisyona ta��
                obje.transform.position = new Vector3(x, y, z); // x, y, z de�erlerini istedi�iniz konum de�erleriyle de�i�tirin
            }
        }
       
    }

}
