using UnityEngine;
using UnityEngine.SceneManagement;

//	Abhi Tech Games (c)


public class SceneOpener : MonoBehaviour
{
public GameObject AudioManager;
	void Awake()
	{
		DontDestroyOnLoad(AudioManager);
	}
	public void OnPress()
	{
		SceneManager.LoadScene("Level1");
	}
}
