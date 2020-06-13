using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class charecter : MonoBehaviour
{
    [SerializeField]
    private int lives = 3;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject firsttypeofenemy;
    public GameObject firsttypeofmeteor;
    public GameObject player;
    public Rigidbody2D myrigidbody;
    public Animator animator;
    public SpriteRenderer sprite;
    private bullet bullet;
    

    private void Awake()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        bullet = Resources.Load<bullet>("bullet");


    }
    private void Update()
    {
        if (lives <= 0)
        {
            Destroy(life3);
            Destroy(player);
            SceneManager.LoadScene("mainmenu");
        }
        if (lives == 2)
            Destroy(life1);
        if (lives == 1)
            Destroy(life2);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
            lives -= 1;
        if (coll.gameObject.tag == "enemybullet")
            lives -= 1;
    }
}





