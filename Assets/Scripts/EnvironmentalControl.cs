using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentalControl : MonoBehaviour {

	[SerializeField] public GameObject[] environmentalObjects_ = new GameObject[3];

	public void OnClickButton(int index) 
	{
		for (int i = 0; i < environmentalObjects_.Length; i++) 
		{
			if (i == index) 
			{
				environmentalObjects_[i].SetActive(true);
			} 
			else 
			{
				environmentalObjects_[i].SetActive(false);
			}
		}
	}
}
