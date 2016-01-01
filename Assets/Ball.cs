using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float thrust = 500;
    public Rigidbody rb;
    Vector3 left = new Vector3(-1.0f, .01f, 0f);
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(rb.transform.forward);
        rb.AddForce(left * thrust);
    }

   
	// Update is called once per frame
	void Update ()
    {
	
	}
}
