

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject brush; // F�r�a objesini tutacak de�i�ken
    public Color currentColor; // �u anki renki tutacak de�i�ken
    private AudioSource audioSource; // Ses kayna��n� tutacak de�i�ken
    public Vector3 position = Vector3.zero; // Fare pozisyonunu tutacak de�i�ken

    private void Start()
    {
        // Komponentleri ba�lang��ta al
        audioSource = GetComponent<AudioSource>();

    }

    public void Update()
    {
        // Fare pozisyonunu ekran koordinatlar�ndan d�nya koordinatlar�na d�n��t�r
        // Fare pozisyonunu ekran koordinatlar�ndan d�nya koordinatlar�na d�n��t�r
        position = Camera.main.ScreenToWorldPoint(new Vector3(
            Mathf.Clamp(Input.mousePosition.x, 0, Screen.width),
            Mathf.Clamp(Input.mousePosition.y, 0, Screen.height),
            Camera.main.nearClipPlane
        ));

        position.z = -5f; // Z koordinat�n� ayarla

        if (Input.GetMouseButtonDown(0))
        {
            RayCast2D();
        }

        if (brush != null)
        {
            brush.transform.position = position;
        }
        
    }

    public void RayCast2D()
    {
        // Raycast i�lemi ger�ekle�tir
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero);

        // E�er bir �ey t�kland�ysa
        if (hit.collider != null)
        {
            // T�klanan obje "BrushColor" tag'ine sahipse
            if (hit.collider.CompareTag("BrushColor"))
            {
                // �u anki rengi g�ncelle
                currentColor = hit.collider.GetComponent<SpriteRenderer>().color;
                brush.transform.GetChild(0).GetComponent<SpriteRenderer>().color = currentColor;
            }
            // T�klanan obje "ImagePart" tag'ine sahipse
            else if (hit.collider.CompareTag("ImagePart"))
            {
                // Objeyi �u anki renkle boyala
                hit.collider.GetComponent<SpriteRenderer>().color = currentColor;
                // Ses �al
                audioSource.Play();
            }
        }
        Debug.Log("Hit object: " + hit.collider);
    }
}
