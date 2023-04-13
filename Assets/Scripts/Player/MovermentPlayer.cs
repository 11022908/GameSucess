using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class MovermentPlayer : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator anim;
    public float speed = 5f;
    //public Animator anim;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-Time.deltaTime * speed, 0));//cach1 tao nhan vat di chuyen
            //rb2d.AddForce(new Vector2(-speed, 0)); // cach 2 tao nhan vat di chuyen          
            transform.localScale = new Vector2(-1f, 1f);
            Running();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(Time.deltaTime * speed, 0));    
            transform.localScale = new Vector2(1f, 1f);
            Running();
        }
        if (Input.GetKey(KeyCode.Space))
        {    
            transform.Translate(new Vector2(0, Time.deltaTime * 25f));
            Jumping();
        }
        Idle();
    }
    public void Idle()
    {
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", false);
        anim.Play("PlayerIdle");
    }
    public void Running()
    {
        anim.SetBool("isRun", true);
        anim.Play("PlayerRun");
    }
    public void Jumping()
    {
        anim.SetBool("isJump", true);
        anim.Play("Playerjump");
    }
}
