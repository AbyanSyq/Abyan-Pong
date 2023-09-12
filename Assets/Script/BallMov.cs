using UnityEngine;

public class BallMov : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballRb;
    [SerializeField] private Vector2 movSpeed;
    void Start()
    {
        ballRb.velocity = movSpeed;
    }

}
