using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement Movement;
	public GameManager GameManager;

	private void OnCollisionEnter (Collision collisionInfo) 
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			GetComponent<PlayerMovement>().enabled = false;
			FindObjectOfType<GameManager>().GameOver();
		}
	}
}
