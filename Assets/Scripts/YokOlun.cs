using UnityEngine;

public class YokOlun : MonoBehaviour
{
    private void Update()
    {
       
        //Debug.DrawRay(transform.position, transform.up * 15, Color.red, 0);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up * 15);

        if(hit.collider != null)
        {
                hit.collider.gameObject.SetActive(false);           
        }
    }

}

