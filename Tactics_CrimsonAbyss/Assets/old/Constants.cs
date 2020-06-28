using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Constants : MonoBehaviour
{
    //game states
    private enum GameState { Menu, Cutscene, PlayerAction, Movement, GameOver, BattleScreen, EndGame }
    private GameState currentState;
    private GameObject playerActionObject, menuObject, cutsceneObject, movementObject, 
        gameOverObject, battleScreenObject, endGameObject;
    //economia
    public int playerTotalOre;


    // Start is called before the first frame update
    void Start()
    {
        playerActionObject = GameObject.FindGameObjectWithTag("playerActionObject");
        menuObject = GameObject.FindGameObjectWithTag("menuObject");
        cutsceneObject = GameObject.FindGameObjectWithTag("cutsceneObject");
        movementObject = GameObject.FindGameObjectWithTag("movementObject");
        gameOverObject = GameObject.FindGameObjectWithTag("gameOverObject");
        battleScreenObject = GameObject.FindGameObjectWithTag("battleScreenObject");
        endGameObject = GameObject.FindGameObjectWithTag("endGameObject");
        //set current gamestate
        currentState = GameState.PlayerAction;

        //set false objects at first
        movementObject.SetActive(false);
        menuObject.SetActive(false);
        cutsceneObject.SetActive(false);
        battleScreenObject.SetActive(false);
        endGameObject.SetActive(false);
        playerActionObject.SetActive(true);

        //character objects
        playerActionObject = GameObject.FindGameObjectWithTag("playerActionObject");
        playerActionObject = GameObject.FindGameObjectWithTag("playerActionObject");
        playerActionObject = GameObject.FindGameObjectWithTag("playerActionObject");
    }

    // Update is called once per frame

    void Update()
    {
        if (currentState == GameState.Movement)
        {
            movementObject.SetActive(true);
            menuObject.SetActive(false);
            cutsceneObject.SetActive(false);
            battleScreenObject.SetActive(false);
            endGameObject.SetActive(false);
            playerActionObject.SetActive(false);
            GameObject.Find("Main Camera").transform.rotation = Quaternion.Euler(60f, 0f, 0f);
            GameObject.Find("Main Camera").transform.position = new Vector3(0, 10f, -7f);
            Time.timeScale = 1f;

        }
        else if (currentState == GameState.PlayerAction) {
            Time.timeScale = 0f;
            movementObject.SetActive(true);
            menuObject.SetActive(false);
            cutsceneObject.SetActive(false);
            battleScreenObject.SetActive(false);
            endGameObject.SetActive(false);
            playerActionObject.SetActive(true);
        }
    }



    public void GameStateSelectMovement ()
    {
        currentState = GameState.Movement;
    }

    public void GameStateSelectPlayerAction()
    {
        currentState = GameState.PlayerAction;

    }





}
