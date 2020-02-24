using UnityEngine;
using UnityEngine.SceneManagement;

//	Abhi Tech Games (c)

public class EarthAttracter : MonoBehaviour
{
    public float AttractionForce;
    public float OffsetForce;
    public SpriteRenderer spriteRenderer;
    public Sprite HappyEarth;
    public Sprite SadEarth;
    public Transform BlackHole;
    private float StartingPosInX;
    private Rigidbody2D rb;
    public Rigidbody2D Blackhole;
    public GameObject DestroyEffect;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartingPosInX = transform.position.x;
    }

    private void FixedUpdate()
    {
        Vector2 Distance = rb.position - Blackhole.position;
	Vector2 Force = Distance.normalized * -AttractionForce;
	rb.AddForce(Force);
        if(transform.position.x < StartingPosInX)
        {
            spriteRenderer.sprite = HappyEarth;
        }
        else
        {
            spriteRenderer.sprite = SadEarth;
        }
        if(Vector2.Distance(transform.position,BlackHole.position) <= 1f)
        {
            Destroy(gameObject);
            Instantiate(DestroyEffect,transform.position,Quaternion.identity);
        }
	}
	
}
