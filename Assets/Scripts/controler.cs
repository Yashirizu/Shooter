using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public MovementEtTir Move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Move.move(Vector3.left);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            Move.move(Vector3.right);
        }
      

    }

}
