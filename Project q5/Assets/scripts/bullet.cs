using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public GameObject gh;
    private float speed = 20.0F;
    public int bulletlives=1;
    private SpriteRenderer sprite;
    private Vector3 direction;
    private Vector3 Direction { set { Direction = value; } }
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "wall")
            bulletlives -= 1;
        if (coll.gameObject.tag == "enemywall")
            bulletlives -= 1;
        if (coll.gameObject.tag == "enemy")
            bulletlives -= 1;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        if (bulletlives <= 0)
                {
            Destroy(gh);
        }
            
    }

}
