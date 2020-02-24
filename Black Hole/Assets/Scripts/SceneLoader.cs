using UnityEngine;
using UnityEngine.SceneManagement;

//	Abhi Tech Games (c)


public class SceneLoader : MonoBehaviour
{
    public GameObject Earth;

    void Update()
    {
        if(Earth == null)
	{
		Invoke("RestartLevel",2f);
	}
    }
	private void RestartLevel()
    	{
		SceneManager.LoadScene("Level1");
    	}
}
