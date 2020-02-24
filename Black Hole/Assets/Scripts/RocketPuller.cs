using UnityEngine;


//	Abhi Tech Games (c)


public class RocketPuller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float MaxHealth;
    private Vector2 MoveVector;
    public float RocketForce;
    public GameObject RocketBrustEffect; 

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        MoveVector = new Vector2( -RocketForce * Time.deltaTime, 0f);
        MaxHealth = 10f;
    }
    private void FixedUpdate() {
        rb.AddForce(MoveVector,ForceMode2D.Impulse);
        MaxHealth -= Time.deltaTime;
        if(MaxHealth <= 0)
        {
            MaxHealth = 0f;
            Destroy(gameObject);
	    Instantiate(RocketBrustEffect,transform.position,Quaternion.identity);
        }
    }
}
