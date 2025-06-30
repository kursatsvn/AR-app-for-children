using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sonuç : MonoBehaviour
{
    public Text dogruText;
    public Text yanlisText;
    private void OnEnable()
    {
        int dogruSayac = VeriTaşıma.instance.dogruSayac;
        int yanlisSayac = VeriTaşıma.instance.yanlisSayac;
        Debug.Log("Dogru Sayac: " + dogruSayac);
        Debug.Log("Yanlis Sayac: " + yanlisSayac);

        // UI elemanlarına sonuçları yazdır
        dogruText.text = "Doğru: " + dogruSayac.ToString();
        yanlisText.text = "Yanlış: " + yanlisSayac.ToString();

        // VeriTaşıma objesini sıfırla (isteğe bağlı)
        VeriTaşıma.instance.dogruSayac = 0;
        VeriTaşıma.instance.yanlisSayac = 0;
    }
    
}
