using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollideWithPlayer : MonoBehaviour
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
        if (other.tag == "EnemyBullet")
        {
            // destroy the bullet
            Destroy(other.gameObject);
            // get player position
            Vector3 pos = gameObject.transform.position;
            // play explosion particle effect
            ParticleSystem expClone = Instantiate(explosion, pos, Quaternion.identity);
            expClone.Play();
            // destroy the player
            Destroy(gameObject);
            Destroy(expClone);
        }
    }
}
