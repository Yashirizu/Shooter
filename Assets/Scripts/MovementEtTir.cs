using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public int destroyBullet;
    public GameObject Bonus;
    

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void move(Vector3 direction)
    {
        transform.position += direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
    
        

        if(transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GameObject createBullet = Instantiate(bullet, transform.position, transform.rotation);
        //   createBullet.GetComponent<Bullet>().tir = this;
        //}
    }


}
