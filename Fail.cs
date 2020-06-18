using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail : MonoBehaviour
{

	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	private void OnTriggerEnter(Collider other)
    {
		//if (collisionInfo.collider.tag == "Enemy") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		//}
    }
}
