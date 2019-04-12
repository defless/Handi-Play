using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    AudioSource audioData;
    
    private Vector3 offset;
    public float m_offset=1000f;
    GameObject new_pipe_up;
    GameObject new_pipe_down;
    GameObject new_hole_detection;
    GameObject new_Background_1;
    public GameObject pipe_up_ref;
    public GameObject pipe_down_ref;
    public GameObject hole_detection_ref;
    public GameObject Background_1_ref;


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

        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Tab))
        {
            float n = (Random.Range(0,2)*2-1) * Random.Range(0,300);

            new_pipe_up = Instantiate(pipe_up_ref, new Vector3(pipe_up_ref.transform.position.x + m_offset, 400 + n , 5), pipe_up_ref.transform.rotation);
            new_pipe_down = Instantiate(pipe_down_ref, new Vector3(pipe_down_ref.transform.position.x + m_offset, -400 + n , 5), pipe_down_ref.transform.rotation);
            new_hole_detection = Instantiate(hole_detection_ref, new Vector3(hole_detection_ref.transform.position.x + m_offset,  n , 0), hole_detection_ref.transform.rotation);
            new_Background_1 = Instantiate(Background_1_ref, new Vector3(Background_1_ref.transform.position.x + 1350,  0 , 0), Background_1_ref.transform.rotation);
            pipe_up_ref=new_pipe_up;
            pipe_down_ref=new_pipe_down;
            hole_detection_ref = new_hole_detection;
            Background_1_ref = new_Background_1;

            
        }
    }

}
