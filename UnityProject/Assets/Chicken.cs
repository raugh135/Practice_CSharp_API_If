using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour {

    public Animator m_animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E))
        {
            m_animator.SetTrigger("吃飯觸發器");
        }
        if (Input.GetKey(KeyCode.R))
        {
            m_animator.SetBool("跑步開關",true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            m_animator.SetBool("跑步開關", false);
        }
    }
}
