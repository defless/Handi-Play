using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzonefloor : MonoBehaviour
{
	AudioSource audioData;
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
