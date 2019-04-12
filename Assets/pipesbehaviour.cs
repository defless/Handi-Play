using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesbehaviour : MonoBehaviour
{

	public Rigidbody2D m_rb2D;

    /*float m_restartChrono = 0f;
    public float m_timeToRestart = 0.5f;
    bool mustRestart = false;
	*/

	AudioSource audioData;


    // Start is called before the first frame update
    void Start()
    {
        /*
        if (mustRestart) {
            m_restartChrono += Time.deltaTime;

            if (m_restartChrono > m_timeToRestart) {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        */
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		

    }
    void OnCollisionEnter2D(Collision2D col)
    {
    	if(col.gameObject.name=="Player")
    	{
    		audioData = GetComponent<AudioSource>();
        	audioData.Play(0);
           //mustRestart = true;
    		Invoke("restart",1);
    		
    	}
    }
    void restart()
    {
    	Application.LoadLevel(Application.loadedLevel);
    }	
	
}
