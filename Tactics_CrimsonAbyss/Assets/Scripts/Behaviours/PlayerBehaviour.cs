using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class PlayerBehaviour : MonoBehaviour
{

    public int ID;
    public string classe;
    public string material;

    public int hpTotal;
    public int currentHPPlayer;

    public int tpTotal;
    public int currentTPPlayer;
    public int level;
    public int DF; //defesa
    public int AT; //ataque
    public int dano; //dano

    public GameObject attackButton;
    bool _clickable = false;

    public int currentHPEnemyNOW;

    public GameObject enemyNOW;

    void Start()
    {
        attackButton.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("battletime, i'm the ENEMY entering");

            if (this.gameObject.GetComponent<PlayerMove>().turn == true) {
                hpTotal = hpTotal - 5;
                if (hpTotal <= 0)
                {
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
}