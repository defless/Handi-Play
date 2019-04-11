using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesbehaviour : MonoBehaviour
{

	public Rigidbody2D m_rb2D;
	GameObject pipe_up;
	GameObject pipe_down;
	GameObject new_pipe_up;
	GameObject new_pipe_down;
	public float offset=1000f;
	bool isCreated =false;
	

	AudioSource audioData;


    // Start is called before the first frame update
    void Start()
    {
        GameObject pipe_up = GameObject.Find("Pipe_up");
	 	GameObject pipe_down = pipe_down=GameObject.Find("Pipe_down");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Tab))
    	{
    		GameObject pipe_up = GameObject.Find("Pipe_up");
	 		GameObject pipe_down = pipe_down=GameObject.Find("Pipe_down");
    		float n = (Random.Range(0,2)*2-1) * Random.Range(100,300);
    		if (!isCreated ){
				new_pipe_up = Instantiate(pipe_up, new Vector3(pipe_up.transform.position.x + offset, 400 + n , transform.position.z), pipe_up.transform.rotation);
				new_pipe_down = Instantiate(pipe_down, new Vector3(pipe_down.transform.position.x + offset, -400 + n , transform.position.z), pipe_down.transform.rotation);
				Destroy(pipe_up);
				Destroy(pipe_down);
				new_pipe_up.name="Pipe_up";
				new_pipe_down.name="Pipe_down";
				isCreated=true;
    		}
		}
		

    }
    void OnCollisionEnter2D(Collision2D col)
    {
    	if(col.gameObject.name=="Player")
    	{
    		audioData = GetComponent<AudioSource>();
        	audioData.Play(0);
    		Invoke("restart",1);
    		
    	}
    }
    void restart()
    {
    	Application.LoadLevel(Application.loadedLevel);
    }	
	
}
