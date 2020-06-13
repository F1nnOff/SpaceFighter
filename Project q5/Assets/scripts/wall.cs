using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    private int walllives = 1;
    public GameObject wll;

    public Rigidbody2D myrigidbody;
    public Animator animator;
    public SpriteRenderer sprite;

    private void Awake()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        if (walllives <= 0)
            Destroy(wll);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet")
            walllives -= 1;
    }
}

