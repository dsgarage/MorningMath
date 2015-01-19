using UnityEngine;
using System.Collections;

public class Fibonacci : MonoBehaviour {

	private int m_count = 0;
	private int m_maxCount = 30;

	private int[] m_fibonacci = {0,0};
	private int m_answer = 0;
	
	// Update is called once per frame
	void Update () {
		if(m_count < m_maxCount){
			if(m_fibonacci[0] == 0 || m_fibonacci[1] == 0){
				m_answer = 1;
				Debug.Log("Count:" + m_count + " Is init\n" + "Fibonacci:" + m_answer);
				m_fibonacci = new int[]{ m_answer, m_fibonacci[0]};
			}

			else{
				m_answer = m_fibonacci[0] + m_fibonacci[1]; 
				Debug.Log("Count:" + m_count + " Is Cal\n" + "Fibonacci:" + m_answer);
				m_fibonacci = new int[]{ m_fibonacci[1], m_answer };
			}
			m_count ++;
		}

	}

}
