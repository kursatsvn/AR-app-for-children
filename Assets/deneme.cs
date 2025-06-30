using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelseçme : MonoBehaviour
{
    public GameObject modelprefab1;
    public GameObject modelprefab2;
    public GameObject modelprefab3;

    public Transform modelposition;
    private GameObject currentModel;
    public void modelsecme()
    {
        Instantiate(modelprefab1, modelposition.position, modelprefab1.transform.rotation);
    }
    public void modelsecme2()
    {
        Instantiate(modelprefab2, modelposition.position, modelprefab2.transform.rotation);
    }
    public void modelsecme3()
    {
        Instantiate(modelprefab3, modelposition.position, modelprefab3.transform.rotation);
    }
    private void LoadModel(GameObject modelPrefab)
    {
        // Mevcut model varsa kaldır
        if (currentModel != null)
        {
            Destroy(currentModel);
        }
        currentModel = Instantiate(modelPrefab, modelposition.position, modelprefab1.transform.rotation);
    }
   
}
