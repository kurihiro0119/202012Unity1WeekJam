using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{    
    Rigidbody2D rb;
    float x = -0.8f;
    float y = 0.8f;
    Animator animator;
    SpriteRenderer spriterenderer;
     Sprite coolSun;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriterenderer = gameObject.GetComponent<SpriteRenderer>();
        coolSun = spriterenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(spriterenderer.sprite);
        Debug.Log(coolSun);
        if(spriterenderer.sprite == coolSun){
            Debug.Log("眠る");
            Score.susStatus_sleeping();
        }
        else {
            Debug.Log("クール");
            Score.susStatus_cool();
        }

        if(Input.GetKeyDown("space"))
        {
            x = 0;
            y = 0;
            animator.enabled = false;
        }

        Debug.Log("太陽の状態" + Score.sunstatus);
    }

    void FixedUpdate(){
        //Press the Up arrow key to move the RigidBody upwards
            rb.velocity = new Vector2( x, y);


    }

}
