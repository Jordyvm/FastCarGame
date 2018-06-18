using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class gameReset : MonoBehaviour
{



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            hardRestartGame();
		}
    }

	void Update()
	{
		if(Input.GetKeyDown( "r" )){
            hardRestartGame();
        }
	}

    public void hardRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

