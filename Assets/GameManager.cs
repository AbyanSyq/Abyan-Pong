using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    [SerializeField]Rigidbody2D player01;
    [SerializeField]Rigidbody2D player02;
    public void BackToMenu(){
        SceneManager.LoadScene(0);
    }
    
    
    private void Update() {
        //Debug.Log("leftPaddle = " + player01  + " rightPaddle " + player02);
        Debug.Log("leftPaddle : " + player01.velocity + " rightPaddle" + player02.velocity);
    }
    
}
