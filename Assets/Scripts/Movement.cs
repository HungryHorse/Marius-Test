using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;

    private Transform cubeTransform;

	// Use this for initialization
	void Start ()
    {
        cubeTransform = transform;
	}
	
	// Update is called once per frame
	void Update ()
    {

        // cubeTransform.position += cubeTransform.forward * speed * Time.deltaTime;	
	}
    
}
