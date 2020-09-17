using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickMOVE : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
       // public float speed = 0.1f // global value for the project
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.RightArrow)) 
       {
         
          GetComponent<Transform>().Translate(new Vector3(1, 0, 0) * 0.05f ); 
         //or I could write transform.Translate(new Vector3.right * speed); 
            GetComponent<Animator>().Play("walk_right");
      
       } else if (Input.GetKey(KeyCode.LeftArrow))

       {
            GetComponent<Transform>().Translate(new Vector3(-1, 0, 0) * 0.05f ); 
            //or I could write transform.Translate(new Vector3.left * 0.1f ); 
            GetComponent<Animator>().Play("walk_left");
     
       } else if (Input.GetKey(KeyCode.DownArrow))
        { 
             GetComponent<Transform>().Translate(new Vector3(0, -1, 0 ) *0.05f ); 
             GetComponent<Animator>().Play("jump");
        
        
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Transform>().Translate(new Vector3(0, 1, 0) * 0.05f ); 
             GetComponent<Animator>().Play("jump");
        } else 
        {
             GetComponent<Animator>().Play("idle");

        }


       

    }
}
