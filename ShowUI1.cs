using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI1 : MonoBehaviour
{
	public GameObject uiobject;

	// Start is called before the first frame update
	void Start()
	{
		uiobject.SetActive (false);
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey("h")){
			uiobject.SetActive (true);

		}
	}

}
