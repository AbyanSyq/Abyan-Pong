using UnityEngine;
using UnityEngine.UI;
public class ScoreText02 : MonoBehaviour
{
    [SerializeField] Text Score01;
    private int scoreAmount = 0;
    private void Start(){
        Score01.text = scoreAmount.ToString("00");
    }
    public void ScoreUI(){
        scoreAmount++;
        Score01.text = scoreAmount.ToString("00");
        if (scoreAmount >= 5)
        {
            FindAnyObjectByType<GameManager>().BackToMenu();
        }
        else
        {
            FindAnyObjectByType<BallMov>().BallReset();
        }
    }
}
