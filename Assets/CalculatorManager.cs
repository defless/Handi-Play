using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorManager : MonoBehaviour
{
	public float m_a = 0f;
	public float m_b = 0f;
	public float m_result = 0f;

	public enum OperationType {ADD, SUB, MULT, DIV};
	public OperationType m_currentOperation = OperationType.ADD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
      
		if (m_currentOperation == OperationType.ADD)
		{
			m_result = Add(m_a, m_b);
		}
		if (m_currentOperation == OperationType.SUB)
		{
			m_result = Sub(m_a, m_b);
		}
		if (m_currentOperation == OperationType.MULT)
		{
			m_result = Mult(m_a, m_b);
		}
		if (m_currentOperation == OperationType.DIV)
		{
			m_result = Div(m_a, m_b);
		}

    }
    float Add(float x, float y)
    {
	return x + y; 
	}
	float Sub(float x, float y)
    {
	return x - y; 
	}
	float Mult(float x, float y)
    {
	return x * y; 
	}
	float Div(float x, float y)
    {
	return x / y; 
	}
}
