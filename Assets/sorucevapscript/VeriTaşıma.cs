using UnityEngine;

public class VeriTaşıma : MonoBehaviour
{
    public int dogruSayac = 0;
    public int yanlisSayac = 0;

    public static VeriTaşıma instance;

    private void OnEnable()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        
    }
}
