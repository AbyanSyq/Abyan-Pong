
using UnityEngine;


public class PlayerController01 : MonoBehaviour
{
    public Rigidbody2D PlayerRb;
    [SerializeField] private float movSpeed;
    private float Movdirection;
    
    
    private void FixedUpdate() {
        playerController();
    }
    private void Update() {
       input(); 
    }
    private void playerController(){
        PlayerRb.velocity = new Vector2(0, Movdirection * movSpeed );
    }

    private void input(){
        Movdirection = Input.GetAxisRaw("Vertical02"); 
    }
}
