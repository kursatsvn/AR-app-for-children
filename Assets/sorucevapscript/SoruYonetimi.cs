using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoruYonetimi : MonoBehaviour
{
    public Text dogruText;
    public Text yanlisText;

    private void Start()
    {
       // ResetSayac();
    }

    public void DogruCevap()
    {
        VeriTa��ma.instance.dogruSayac++;
        UpdateSayacText();
    }

    public void YanlisCevap()
    {
        VeriTa��ma.instance.yanlisSayac++;
        UpdateSayacText();
    }

    private void UpdateSayacText()
    {
        if (dogruText == null || yanlisText == null)
        {
            Debug.LogError("dogruText or yanlisText is null!");
            return;
        }

        dogruText.text = "Do�ru: " + VeriTa��ma.instance.dogruSayac.ToString();
        yanlisText.text = "Yanl��: " + VeriTa��ma.instance.yanlisSayac.ToString();

    }

    private void ResetSayac()
    {
        VeriTa��ma.instance.dogruSayac = 0;
        VeriTa��ma.instance.yanlisSayac = 0;
        UpdateSayacText();
    }

}