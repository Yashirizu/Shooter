using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemis : MonoBehaviour
{
    public scoremanager monscoremanager;
    //public Transform parent;
    public Bonus PowerUp;
    //public Transform LimiteTop;

    public int vie;
    void Start()
    {
        monscoremanager = FindObjectOfType<scoremanager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        vie--;
    }


    void Update()
    {
        if (vie <= 0)
        {
            Instantiate(PowerUp, this.transform.position, this.transform.rotation);

            monscoremanager.score++;
            Destroy(gameObject);
            //monscoremanager.score = ++;
        }


        //if (transform.position.y < LimiteTop.position.y)
        //{
        //    transform.position = new Vector3(LimiteTop.position.x, transform.position.y, transform.position.z);
        //}
    }
}
