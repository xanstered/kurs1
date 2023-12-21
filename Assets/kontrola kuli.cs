using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody - transform.GetComponent<rigidbody>();

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddTorque(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("W dol");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("W lewo");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("W prawo");
        }
    }
}
