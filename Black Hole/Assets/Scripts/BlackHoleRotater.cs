using UnityEngine;


//	Abhi Tech Games (c)


public class BlackHoleRotater : MonoBehaviour
{
    public float RotateAmount;
    void Update()
    {
        transform.Rotate( 0f, 0f, RotateAmount);
    }
}
