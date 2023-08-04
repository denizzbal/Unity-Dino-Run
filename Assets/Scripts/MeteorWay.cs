using UnityEngine;

public class MeteorWay : MonoBehaviour
{
    float _gidisHizi = 16.0f;

    private void Start()
    {
        InvokeRepeating("Move", 0.1f, 0.1f);
    }


    private void Move()
    {
        transform.Translate(new Vector3(-1f, -0.5f, 0) * Time.deltaTime * _gidisHizi);
    }
}
