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
        VeriTaþýma.instance.dogruSayac++;
        UpdateSayacText();
    }

    public void YanlisCevap()
    {
        VeriTaþýma.instance.yanlisSayac++;
        UpdateSayacText();
    }

    private void UpdateSayacText()
    {
        if (dogruText == null || yanlisText == null)
        {
            Debug.LogError("dogruText or yanlisText is null!");
            return;
        }

        dogruText.text = "Doðru: " + VeriTaþýma.instance.dogruSayac.ToString();
        yanlisText.text = "Yanlýþ: " + VeriTaþýma.instance.yanlisSayac.ToString();

    }

    private void ResetSayac()
    {
        VeriTaþýma.instance.dogruSayac = 0;
        VeriTaþýma.instance.yanlisSayac = 0;
        UpdateSayacText();
    }

}