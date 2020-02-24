using UnityEngine;

//	Abhi Tech Games (c)

public class Chain : MonoBehaviour
{
    public Rigidbody2D hook;
    private ChainEndJoint chainEndScript;
    public GameObject Link;
    public int NumberOfLink = 7;

    void Start()
    {
	GameObject Earth = GameObject.FindWithTag("Earth");
	if(Earth!=null)
	{	
        chainEndScript = Earth.GetComponent<ChainEndJoint>();
	GenerateRope();
	}
    }
    private void GenerateRope()
    {
        Rigidbody2D previousRb = hook;
        for (int i = 0; i < NumberOfLink; i++)
        {
            GameObject LinkPrefab = Instantiate(Link ,transform);
            HingeJoint2D joint = LinkPrefab.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRb;
            if(i < NumberOfLink-1)
            {
                previousRb = LinkPrefab.GetComponent<Rigidbody2D>();
            }
            else
            {
                chainEndScript.JoinTheLastChain(LinkPrefab.GetComponent<Rigidbody2D>());
            }
        }
    }
}
