using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor.IMGUI.Controls;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject auhtorPanel;
    private void Update() {
        input();
    }
    private void input(){
        if(Input.GetKey(KeyCode.Escape)){
            AuthorDisplayOut();
        }
    }
    

    public void LoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void AuthorDisplay(){
        auhtorPanel.SetActive(true);
        Debug.Log("Created By : Muhammad Abyan Syauqi");
    }
    public void AuthorDisplayOut(){
        auhtorPanel.SetActive(false);
    }

    
}
