using UnityEngine;


//	Abhi Tech Games (c)


public class DragDropFreezeSpell : MonoBehaviour
{
    public GameObject FreezeSpell;
    public float FreezeTime;
    private EarthAttracter earthAttracter;
    private GameObject Freeze;
    private Vector2 mousePos;
    private GameObject MoveUI;
    public GameObject BlackHole;
    private bool selected = false;
    private bool firstTime = false;
    private bool firstTime1 = false;

    private void Start() {
        earthAttracter = FindObjectOfType<EarthAttracter>();
    }
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
            if(firstTime == true)
            {
                Freeze = Instantiate(FreezeSpell,BlackHole.transform.position,Quaternion.identity);
                firstTime = false;
            }
        }
        if(Freeze != null)
        {
            earthAttracter.AttractionForce = 100f;
            earthAttracter.OffsetForce = 0f;
            FreezeTime -= Time.deltaTime;
            if(FreezeTime <= 0)
            {
                earthAttracter.AttractionForce = 200f;
                earthAttracter.OffsetForce = 0.5f;
                FreezeTime = 2f;
                Destroy(Freeze);
            }
        }
    }
}
