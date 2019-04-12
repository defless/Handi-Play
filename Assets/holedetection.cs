using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holedetection : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D col)
    {
    	if(col.gameObject.name=="Player")
    	{
    		audioData = GetComponent<AudioSource>();
        	audioData.Play(0);
    		
    	}
    }

    void OnTriggerExit2D(Collider2D col)
    {
    	if(col.gameObject.name=="Player")
    	{
    		audioData = GetComponent<AudioSource>();
        	audioData.Stop();
    		
    	}
    }
}
