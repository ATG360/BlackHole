using UnityEngine;


//	Abhi Tech Games (c)


public class EarthFollowers : MonoBehaviour
{
    public Transform Earth;
    public bool mousePos = false;
    void Update()
    {
	if(Earth != null && mousePos == false)
        transform.position = Earth.position;
	if(Earth != null && mousePos == true)
        transform.position = new Vector3(Earth.position.x,Earth.position.y,-10f);
    }
} 
