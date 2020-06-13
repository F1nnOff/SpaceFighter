using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 0;
    [SerializeField]
    private int enemylives = 1;
    public Rigidbody2D myrigidbody;
    public Animator animator;
    public SpriteRenderer sprite;
    public GameObject me;
    private void Awake()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        if (enemylives <= 0)
            Destroy(me);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet")
            enemylives -= 1;
        if (coll.gameObject.tag == "Player")
            enemylives -= 1;
    }
}


