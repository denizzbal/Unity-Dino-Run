using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFly : MonoBehaviour
{
    public float _gidisHizi = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {       
        
        transform.Translate(Vector3.left * _gidisHizi * Time.deltaTime);
        //Vector3 pos = new Vector3(-_gidisHizi * Time.deltaTime, 0, 0);
        //transform.position += pos;
    }
}
