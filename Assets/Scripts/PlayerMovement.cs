using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody PlayerRigidBody = null;
    private const float UnderPlatform = -1f;
    public float ForwardForce = 3500f;
    public float SidewaysForce = 175f;
   
    private void FixedUpdate()
    {
        PlayerRigidBody.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            PlayerRigidBody.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            PlayerRigidBody.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (PlayerRigidBody.position.y < UnderPlatform)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
