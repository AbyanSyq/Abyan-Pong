using UnityEngine;

public class GoalCase02 : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
        FindAnyObjectByType<ScoreText02>().ScoreUI();
    }
}
