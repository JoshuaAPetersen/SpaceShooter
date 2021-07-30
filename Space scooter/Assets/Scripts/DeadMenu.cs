using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public void PlayAgain(){
        SceneManager.LoadScene("MainScene");
    }
    public void Back(){
        SceneManager.LoadScene("MainMenu");
    }
}
