
using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
