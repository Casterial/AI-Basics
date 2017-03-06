using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectHit : MonoBehaviour {
    public Slider HealthBar;
    Animator anim;

    public string opponent;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;
        HealthBar.value -= 25;

        if (HealthBar.value <= 0)
            anim.SetBool("isDead", true);
    }



	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
