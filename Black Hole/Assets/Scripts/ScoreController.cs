using UnityEngine;
using UnityEngine.UI;

//	Abhi Tech Games (c)


public class ScoreController : MonoBehaviour
{
    public Text ScoreText;
    private float Score;
    private int ScoreInInteger;
    void Start()
    {
     	Score = 0f;   
    }

    void Update()
    {
	Score += Time.deltaTime;
	ScoreInInteger = (int)Score;
	ScoreText.text = ScoreInInteger.ToString();     
    }
}
