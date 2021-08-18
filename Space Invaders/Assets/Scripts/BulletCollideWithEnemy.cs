using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollideWithEnemy : MonoBehaviour
{

    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerBullet")
        {
            // destroy the bullet
            Destroy(other.gameObject);
            // get enemy position
            Vector3 pos = gameObject.transform.position;
            // play explosion particle effect
            ParticleSystem expClone = Instantiate(explosion, pos, Quaternion.identity);
            expClone.Play();
            // destroy the enemy
            Destroy(gameObject);
            Destroy(expClone);
        }
    }
}
