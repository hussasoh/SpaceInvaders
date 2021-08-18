using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private float lowerdown;
    private Rigidbody rb;
    private float starttime = 0.0f;
    private float startreversetime = 0.0f;

    public GameObject enemyBullet;
    public static System.Random rnd = new System.Random();
    private float bulletstarttime = 0.0f;
    private float bulletendtime;
    private Vector3 bulletmovement = new Vector3();

    public float speed;
    public float endtime;

    private float reversetime = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        EnemyMovement();
        bulletInstantiate();
        


    }

    void EnemyMovement()
    {
        if (Time.time > starttime)
        {
            starttime += endtime;
            transform.position += (new Vector3(speed, 0f, 0f));
            if (Time.time > startreversetime)
            {
                speed = -speed;
                startreversetime += reversetime;
                transform.position += (new Vector3(speed, 0f, 0f));
                transform.position += (new Vector3(0f, -1f, 0f));
            }
        }
    }
    void bulletInstantiate()
    {
        bulletendtime = rnd.Next(1, 5);
        if (Time.time > bulletstarttime)
        {
            bulletstarttime += bulletendtime;
            bulletmovement = transform.position;
            bulletmovement.y = transform.position.y + -0.5f;
            Instantiate(enemyBullet, bulletmovement, Quaternion.identity);
        }
    }
}
