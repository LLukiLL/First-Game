using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;
    // Update is called once per frame
    private void Update()
    {
        transform.position = Player.position + Offset;
    }
}
