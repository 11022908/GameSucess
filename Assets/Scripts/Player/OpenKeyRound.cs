using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyRound : MonoBehaviour
{
    public GameObject doorOpenPos;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    public void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "doorClose")
        {
            this.transform.position = doorOpenPos.transform.position + new Vector3(-2.5f, 0f, 0f);
            this.transform.localScale = new Vector2(-1f, 1f);
        }
    }
}
