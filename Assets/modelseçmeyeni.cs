using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelseçmeyeni : MonoBehaviour
{
    public GameObject[] targetObjects; // Aktive edilecek veya pasif hale getirilecek GameObject dizisi
    void Start()
    {
        // Sahne başladığında tüm GameObject'leri pasif hale getir
        DeactivateAllObjects();
    }
    // Buton 1 için fonksiyon
    public void ActivateObject1()
    {
        ActivateObject(0);
    }

    // Buton 2 için fonksiyon
    public void ActivateObject2()
    {
        ActivateObject(1);
    }

    // Buton 3 için fonksiyon
    public void ActivateObject3()
    {
        ActivateObject(2);
    }

    private void ActivateObject(int index)
    {
        // Belirli bir GameObject'i aktif hale getir
        if (index >= 0 && index < targetObjects.Length)
        {
            // Diğer GameObject'leri pasif hale getir
            DeactivateAllObjects();

            // Seçilen GameObject'i aktif hale getir
            targetObjects[index].SetActive(true);
        }
        else
        {
            Debug.LogError("Invalid index for targetObjects array!");
        }
    }

    private void DeactivateAllObjects()
    {
        // Tüm GameObject'leri pasif hale getir
        foreach (GameObject obj in targetObjects)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}
