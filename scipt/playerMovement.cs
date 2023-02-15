using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce;
    [SerializeField] float score;
    public Text scoreTxt;
    AudioSource jumpsound;
    AudioSource boksound;
   
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        jumpsound=GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * jumpForce;
            jumpsound.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
        if(collision.gameObject.tag=="point")
        {
            score++;
        }

        if(collision.gameObject.tag=="pipa")
        {
            Debug.Log("Hancur");
            Destroy(gameObject);
            Time.timeScale = 0 ;
            SceneManager.LoadScene(2);
            Time.timeScale = 1;
            
        }
        
     }
}

