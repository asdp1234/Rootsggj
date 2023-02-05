using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool go = true;

    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        transform.forward = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        print(transform.forward);
        if (go)
        {

            transform.position += (transform.forward * 0.2f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            go = !go;
        }
        if (Input.GetKey(KeyCode.A))
        {
            print(dir);
            transform.Rotate(new Vector3(0,-1,0) * 40f * Time.deltaTime);
            //dir = (Vector3.down * transform.position);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * 40f * Time.deltaTime);
            
        }


    }
    void OnCollisionEnter(Collision col)
    {
         if (col.transform.gameObject.tag == "wall")
         {
            go = false;
         }
    }
}
