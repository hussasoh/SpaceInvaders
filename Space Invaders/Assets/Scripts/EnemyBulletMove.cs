using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -0.5f, 0f);
        Destroy(gameObject, 1);
    }
}
