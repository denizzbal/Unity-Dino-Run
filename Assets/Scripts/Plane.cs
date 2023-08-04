using UnityEngine;
using TMPro;

public class Plane : MonoBehaviour
{
    public float PlaneGidisHizi = 8f; 
    public TMP_Text MilyonText;

    float currentTime;
    public float saniye;
    
    void Start()
    {
        currentTime = 70.01f;
    }

    
    void Update()
    {
        saniye += Time.deltaTime;
        transform.Translate(-PlaneGidisHizi * Time.deltaTime,0,0); //Plane objesinin hareket kodu

        currentTime -= Time.deltaTime / 2.87f; //
        //MilyonText.text = currentTime.ToString("F3", CultureInfo.InvariantCulture) + "  Million Years Ago";
        MilyonText.text = currentTime.ToString("0.000") + "  Million Years Ago";

        if (currentTime <= 0.5f)
        {
            MilyonText.text = "Present Day";
        }

    }
}
