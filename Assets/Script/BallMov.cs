using UnityEngine;

public class BallMov : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballRb;
    [SerializeField] private Vector2 movSpeed;
    private bool Playing;
    private void Update() {
        if (ballRb.velocity == new Vector2(0,0))
        {
            Playing = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Playing == false)
        {
            StartGame();
        }
    }
    public void BallReset(){
        ballRb.velocity = new Vector3(0,0,0);
        ballRb.position = new Vector3(0,0,0);
    }
    public void StartGame(){
        ballRb.velocity = movSpeed;
    }

}
