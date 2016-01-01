using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

    void Start ()
    {
	
	}
	
	
	void Update ()
    {
        
        float translation = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.position = new Vector3(transform.position.x, translation + transform.position.y, 0);
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, rotation);

    }
}
