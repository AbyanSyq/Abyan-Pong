using UnityEngine;

public class GoalCase01 : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
        FindAnyObjectByType<ScoreText01>().ScoreUI();
    }
}
