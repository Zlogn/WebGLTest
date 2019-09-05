using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebTest : MonoBehaviour {

	public Text m_Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateText() {
		if (m_Text != null) {
			m_Text.text = "Time : " + Time.time;
		}
	}
}
