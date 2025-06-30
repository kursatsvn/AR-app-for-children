

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject brush; // Fýrça objesini tutacak deðiþken
    public Color currentColor; // Þu anki renki tutacak deðiþken
    private AudioSource audioSource; // Ses kaynaðýný tutacak deðiþken
    public Vector3 position = Vector3.zero; // Fare pozisyonunu tutacak deðiþken

    private void Start()
    {
        // Komponentleri baþlangýçta al
        audioSource = GetComponent<AudioSource>();

    }

    public void Update()
    {
        // Fare pozisyonunu ekran koordinatlarýndan dünya koordinatlarýna dönüþtür
        // Fare pozisyonunu ekran koordinatlarýndan dünya koordinatlarýna dönüþtür
        position = Camera.main.ScreenToWorldPoint(new Vector3(
            Mathf.Clamp(Input.mousePosition.x, 0, Screen.width),
            Mathf.Clamp(Input.mousePosition.y, 0, Screen.height),
            Camera.main.nearClipPlane
        ));

        position.z = -5f; // Z koordinatýný ayarla

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
        // Raycast iþlemi gerçekleþtir
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero);

        // Eðer bir þey týklandýysa
        if (hit.collider != null)
        {
            // Týklanan obje "BrushColor" tag'ine sahipse
            if (hit.collider.CompareTag("BrushColor"))
            {
                // Þu anki rengi güncelle
                currentColor = hit.collider.GetComponent<SpriteRenderer>().color;
                brush.transform.GetChild(0).GetComponent<SpriteRenderer>().color = currentColor;
            }
            // Týklanan obje "ImagePart" tag'ine sahipse
            else if (hit.collider.CompareTag("ImagePart"))
            {
                // Objeyi þu anki renkle boyala
                hit.collider.GetComponent<SpriteRenderer>().color = currentColor;
                // Ses çal
                audioSource.Play();
            }
        }
        Debug.Log("Hit object: " + hit.collider);
    }
}
