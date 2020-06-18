using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Use : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey("h")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
    }
}
