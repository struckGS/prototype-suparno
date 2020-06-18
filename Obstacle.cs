using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Enemy") {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
