using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{

    public Vector3 bulletOffset1 = new Vector3(0, 0.2f, 0);
    public Vector3 bulletoffset2 = new Vector3(0, 0.2f, 0);

    public GameObject bulletPrefab;
    int bulletLayer;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
           
            cooldownTimer = fireDelay;

            Vector3 offset1 = transform.rotation * bulletOffset1;
            Vector3 offset2 = transform.rotation * bulletoffset2;


            GameObject bulletGO1 = (GameObject)Instantiate(bulletPrefab, transform.position + offset1, transform.rotation);
            bulletGO1.layer = bulletLayer;
            GameObject bulletGO2 = (GameObject)Instantiate(bulletPrefab, transform.position + offset2, transform.rotation);
            bulletGO2.layer = bulletLayer;
        }
    }
}