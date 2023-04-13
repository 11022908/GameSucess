using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoverment : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb2d;
    private float distance = 6f;
    public float PosStart;
    private bool isRight;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        PosStart = this.transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        var currentPosX = this.transform.position.x;
        if(currentPosX < PosStart - distance)
        {
            isRight = true;
        }
        if(currentPosX > PosStart + distance)
        {
            isRight = false;
        }
        if(isRight == true)
        {
            MoveRight();
        }
        else
        {
            MoveLeft();
        }
    }
    public void MoveLeft()
    {
        transform.Translate(new Vector2(-Time.deltaTime * 2f, 0));
    }
    public void MoveRight()
    {
        transform.Translate(new Vector2(Time.deltaTime * 2f, 0));
    }

}
