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
            // Eðer hedef sahne deðilse, objeyi koruma altýna al
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
            // Eðer sahne adý "anaekran" ise, objeyi yok et
            Destroy(this.gameObject);
        }
        // Þu anki sahnenin adýný al
        string suankiSahneAdi = SceneManager.GetActiveScene().name;

        // Eðer þu anki sahne adý "IlkSahne" ise ve diðer sahneye geçiliyorsa
        if (suankiSahneAdi == "3Dmodel")
        {
            // Diðer sahneye geçildiðinde objenin pozisyonunu ayarla
            GameObject obje = GameObject.Find("Coloring-Page"); // "ObjeninAdi" objenin adýný ve hiyerarþideki ismini temsil eder
            if (obje != null)
            {
                // Objeyi yeni bir pozisyona taþý
                obje.transform.position = new Vector3(x, y, z); // x, y, z deðerlerini istediðiniz konum deðerleriyle deðiþtirin
            }
        }
       
    }

}
