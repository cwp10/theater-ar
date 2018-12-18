using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.HelloAR;

public class DisablePoint : MonoBehaviour {

	private HelloARController _helloARController = null;

	// Use this for initialization
	void Start () {
		_helloARController = GameObject.FindGameObjectWithTag("GameController").GetComponent<HelloARController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(_helloARController.IsInstantiate()) {
			this.gameObject.SetActive(false);
		}
	}
}
