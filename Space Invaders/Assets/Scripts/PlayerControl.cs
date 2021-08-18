using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public AudioSource bulletSound;
    public int speed;
    public GameObject bullet;
    private Vector3 change = new Vector3();


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        PlayerShoot();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -6.4)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 6.4)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void PlayerShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            change = transform.position;
            change.y = transform.position.y + 0.5f;
            Instantiate(bullet, change, Quaternion.identity);
        }
    }



}
