using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //verificar se os jogadores ou os inimigos morreram e finalizar a batalha
    //armazenar os dados do jogador? level, dinheiro, item, arma etc

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject EndBattleOverlay;

    void Start()
    {
        EndBattleOverlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndBattle ()
    {
        if (enemy1.activeInHierarchy == false && enemy2.activeInHierarchy == false && enemy3.activeInHierarchy == false)
        {
            EndBattleOverlay.SetActive(true);
        }
    }

}
