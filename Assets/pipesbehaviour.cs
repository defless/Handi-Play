using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesbehaviour : MonoBehaviour
{

	public Rigidbody2D m_rb2D;
	public float m_dash = 10f;
	float pas=0;
	bool isMoving =false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	/*
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Tab))
    	{
			if (isMoving == false) {
				Vector3 start = transform.position;
				Vector3 end = new Vector3(start.x-40,start.y,start.z);
				isMoving=true;
			}
			else {
				transform.position=Vector3.Lerp(start,end,pas); 
				pas+=m_dash;
			}
		}
		*/
		
    }
}
