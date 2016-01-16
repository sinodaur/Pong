using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float thrust = 500;
    public Rigidbody rb;
    Vector3 left = new Vector3(-1.0f, .01f, 0f);
    Score scoreClass;

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

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.name.Equals("LeftWall"))
            {
                scoreClass = GameObject.Find("Score").GetComponent<Score>();
                Debug.Log("Hit");
                scoreClass.player2Score++;
            }
        else if (collision.collider.name.Equals("RightWall"))
            {
                scoreClass = GameObject.Find("Score").GetComponent<Score>();
                scoreClass.player1Score++;
                Debug.Log("Hit");
            }
    }
}
