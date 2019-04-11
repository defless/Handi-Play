using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesbehaviour : MonoBehaviour
{

	public Rigidbody2D m_rb2D;
	public GameObject pipe;
	public float offset=1000f;
	bool isCreated =false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Tab))
    	{
    		if (!isCreated){
				Instantiate(pipe, new Vector3(pipe.transform.position.x + offset, transform.position.y, transform.position.z), pipe.transform.rotation);
				isCreated=true;
    		}
		}
		

    }
    void OnCollisionEnter2D(Collision2D col)
    {
    	if(col.gameObject.name=="Player")
    	{
    		Application.LoadLevel(Application.loadedLevel);
    }	}
}
