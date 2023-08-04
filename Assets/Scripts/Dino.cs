using UnityEngine;
using UnityEngine.EventSystems;


public class Dino : MonoBehaviour
{
    Rigidbody2D rb;
    public float _ZiplamaGucu = 5f;   //23  Gravity Scale = 7
    bool _DinoAyakYerdemi;
    public GameObject Plane;
    Animator _animator;
    [Header("Panels")]
    public GameObject GameOverPanel;
    public GameObject WinPanel;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _DinoAyakYerdemi = true;

        InvokeRepeating("OyunHizlandir", 10f, 5f);
    }

    
    void Update()
    {       

        if (Input.GetKeyDown(KeyCode.Space) && _DinoAyakYerdemi)
        {
            rb.AddForce(Vector3.up * _ZiplamaGucu, ForceMode2D.Impulse);
            _DinoAyakYerdemi = false;
            _animator.SetBool("DinoAyak", false); //Dino koþma animasyonu duracak

        }

        if(Mathf.Approximately(rb.velocity.y, 0))
        {
            _animator.SetBool("DinoAyak", true); //Dino koþma animasyonu çalýþacak.
            _DinoAyakYerdemi = true;
        }
      

    }

    void OyunHizlandir()
    {
       Time.timeScale += 0.04f;
    }


    private void OnTriggerEnter2D(Collider2D other2d)
    {
        if(other2d.gameObject.CompareTag("cactus") || other2d.gameObject.CompareTag("monster"))
        {
            Time.timeScale = 0f;
            GameOverPanel.SetActive(true);
        }
        if (other2d.gameObject.CompareTag("WinLine"))
        {
            Time.timeScale = 0f;
            WinPanel.SetActive(true);
            
        }
    }

    public void JumpDino()
    {
        if (_DinoAyakYerdemi)
        {
            rb.AddForce(Vector3.up * _ZiplamaGucu, ForceMode2D.Impulse);
            _DinoAyakYerdemi = false;
            _animator.SetBool("DinoAyak", false); //Dino koþma animasyonu duracak
        }

    }






}
