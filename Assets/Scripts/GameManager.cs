using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //PlayerController playerController;
    public GameObject mainMenu;
    //GameObject game;


    //void Start()
    //{
    //    //game = GameObject.FindGameObjectWithTag("GameOverPanel");
    //   //playerController.isGameOver = false;
    //}

    
    //void Update()
    //{
        
    //    if (playerController.isGameOver) {
    //        game.SetActive(true);
    //        Time.timeScale = 0;
            

    //    }
    //}
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void Play() {
        mainMenu.SetActive(false);
        
    }
    public void Menu() {
        mainMenu.SetActive(true);

    }
}
