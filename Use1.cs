using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Use1 : MonoBehaviour
{
    
    void Update()
    {
		if (Input.GetKey ("j")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
    }
}
