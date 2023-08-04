using System.Collections;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public GameObject PatlamaEfekt;
    public GameObject Background;
    float zam = 0f;

    private void Update()
    {
        if (Background.GetComponent<SpriteRenderer>().color.a < 1f)
        {
            zam += 0.03f * Time.deltaTime;
            Background.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 0.3f, zam);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meteor"))
        {
            Destroy(collision.gameObject);
            PatlamaEfekt.SetActive(true);            
            StartCoroutine(Zaman());
        }
    }

    IEnumerator Zaman()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        PatlamaEfekt.SetActive(false);
        yield return new WaitForSecondsRealtime(0.1f);
        Background.GetComponent<SpriteRenderer>().color = new Color(0.2f, 0.2f, 0.2f, 0f);       
    }
}
