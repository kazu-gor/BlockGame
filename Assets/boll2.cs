using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll2 : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right*2) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
