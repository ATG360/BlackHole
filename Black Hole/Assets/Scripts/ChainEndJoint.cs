using UnityEngine;


//	Abhi Tech Games (c)


public class ChainEndJoint : MonoBehaviour
{
    public float DistanceFromLastChain = .6f;
    public void JoinTheLastChain(Rigidbody2D EndRb)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.connectedBody = EndRb;
        joint.autoConfigureConnectedAnchor = false;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2( 0f, DistanceFromLastChain);

    }
}
