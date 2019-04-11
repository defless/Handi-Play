using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    AudioSource audioData;
    
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position  - player.transform.position;
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player == null) {
            return;
        }
        
        transform.position = new Vector3 (player.transform.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
