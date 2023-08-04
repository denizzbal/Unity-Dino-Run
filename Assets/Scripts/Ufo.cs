using UnityEngine;
using System.Collections;

public class Ufo : MonoBehaviour
{

    SpriteRenderer sprite;
    Animator _animator;
    void Start()
    {
        StartCoroutine(SpriteAcKapa());
        sprite = gameObject.GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }


    public IEnumerator SpriteAcKapa()
    {
        while (true)
        {
            yield return new WaitForSeconds(45f);
            float xRandom = Random.Range(-8f, 8f);
            float yRandom = Random.Range(3f, 4f);
            transform.position = new Vector3(xRandom, yRandom);
            _animator.SetBool("acik", true);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

            yield return new WaitForSeconds(1.5f);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            _animator.SetBool("acik", false);
        }

    }

}
