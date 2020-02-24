using UnityEngine;
using UnityEngine.UI;

//	Abhi Tech Games (c)


public class DragDrop : MonoBehaviour
{
    public GameObject RocketType;
public Slider slider;
public float TimeOfLaunch;
private float perfectTime = 0f;
    private Vector2 mousePos;
    private GameObject MoveUI;
    private bool selected = false;
    private bool firstTime = false;
    private bool firstTime1 = false;
    private void OnMouseOver() {
	if(Input.GetMouseButtonDown(0))
        {
            selected = true;
            firstTime = true;
            firstTime1 = true;
        }
    }

    void Update()
    {
perfectTime += Time.deltaTime;

        if(selected == true)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (firstTime1 == true)
            {
                MoveUI = Instantiate(gameObject,transform.position,Quaternion.identity);
                firstTime1 = false;
            }
            MoveUI.transform.position = mousePos;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Destroy(MoveUI);
            firstTime1 = true;
            selected = false;
            if(firstTime == true && perfectTime > TimeOfLaunch)
            {
if(perfectTime > 5f)
	perfectTime = 5f;
perfectTime -= TimeOfLaunch;
                Instantiate(RocketType,mousePos,Quaternion.identity);
                firstTime = false;
            }
        }
	slider.value = perfectTime;
    }
}
