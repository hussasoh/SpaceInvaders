using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMove : MonoBehaviour
{
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        Destroy(gameObject, 1);


    }
}
