using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDie : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject winGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LeftMonster" || collision.gameObject.tag == "RightMonster")
        {
            gameOver.SetActive(true);
        }
        if(collision.gameObject.tag == "AboveMonster")
        {

            var name = collision.transform.parent.gameObject.name; //lấy ra tên cua cha gameobject
            Destroy(GameObject.Find(name));
        }
        if(collision.gameObject.tag == "Alice")
        {
            winGame.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
