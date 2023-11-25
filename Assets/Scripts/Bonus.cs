using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{

    public Rigidbody2D PowerUp;
    public float speed;
    public ennemis Destruction;

    // Start is called before the first frame update
    void Start()
    {
        PowerUp.velocity = Vector3.down * speed;    
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
