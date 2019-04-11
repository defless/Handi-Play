using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerBehaviour : MonoBehaviour
{
	public float m_jump = 30f;
	public float m_gravity = 500f;
	public float m_dash = 1200f;
	public Rigidbody2D m_rb2D;

	public Vector2 m_finishLine;
	public bool mustMove=false;

	AudioSource audioData;



	
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
    	{
			m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_jump * Vector2.up);
			audioData = GetComponent<AudioSource>();
        	audioData.Play(0);
		} 
		else {
			m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_jump/m_gravity * Vector2.down);
		}
		
		if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Tab)){
			if (!mustMove) {
				m_finishLine = new Vector2(m_rb2D.position.x + m_dash, m_rb2D.position.y);
				mustMove = true;
			}
		}

		if (mustMove) {

			m_rb2D.MovePosition(m_rb2D.position + 30 * Vector2.right);
			if (transform.position.x > m_finishLine.x) {
				transform.position = m_finishLine;
				mustMove = false;
			}
		}
    
    }
}
