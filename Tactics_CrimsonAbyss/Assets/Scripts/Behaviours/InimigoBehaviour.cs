using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBehaviour : MonoBehaviour
{

    public int ID;
    public string classe;
    public string material;

    public int hpTotal;
    public int currentHPEnemy;

    public int tpTotal;
    public int currentTPEnemy;

    public int level;
    public GameObject playerObject;

    public int DF; //defesa
    public int AT; //ataque
    public int dano; //dano

    public bool _clickable = false;

    public void Start()
    {

    }

    /*
    //public void VerificarDistancia()
    //{ 
    //if (this.transform.position.x < 0) { (- this.transform.position.x) -playerObj.transform.position.x) 
    //}
    //Debug.Log("enemypositionX: " + this.transform.position.x);
    //Debug.Log("playerObj: " + playerObj.transform.position.x);
    // Debug.Log("distancia: " + distance);
    // if (distance <= 1.5f)
    // {
    //      Debug.Log("foi");
    //       //Time.timeScale = 0;
    //   }
    */

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _clickable = true;
            hpTotal = hpTotal - 5;
            if (hpTotal == 0)
            {
                Debug.Log("voce ganhou, inimigo morto");
                Time.timeScale = 0;
            }
        }
    }


    void OnMouseDown()
    {
        //verifica se o objeto é clicavel
        if (_clickable == true && playerObject.gameObject.GetComponent<PlayerMove>().turn == true)
        {
            //retira vida do inimigo
            Debug.Log("is clickable");
            hpTotal = hpTotal - 5;
            if (hpTotal <= 0) {
                this.gameObject.SetActive(false);
            }
        }
    }
    void Update()
    {

    }
}
