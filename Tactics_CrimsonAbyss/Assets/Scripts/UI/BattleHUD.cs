using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public Slider hpSlider;
    public Slider tpSlider;
    public GameObject enemyObject;

    public void Start() {
        //enemy
        nameText.text = enemyObject.gameObject.GetComponent<InimigoBehaviour>().classe;
        levelText.text = "Lvl " + enemyObject.gameObject.GetComponent<InimigoBehaviour>().level;

        hpSlider.maxValue = enemyObject.gameObject.GetComponent<InimigoBehaviour>().hpTotal;
        hpSlider.value = enemyObject.gameObject.GetComponent<InimigoBehaviour>().currentHPEnemy;

        tpSlider.maxValue = enemyObject.gameObject.GetComponent<InimigoBehaviour>().tpTotal;
        tpSlider.value = enemyObject.gameObject.GetComponent<InimigoBehaviour>().currentTPEnemy;

        //player
        //nameText.text = playerObject.gameObject.GetComponent<PlayerBehaviour>().classe;
        //levelText.text = "Lvl " + playerObject.gameObject.GetComponent<PlayerBehaviour>().level;

        //hpSlider.maxValue = playerObject.gameObject.GetComponent<PlayerBehaviour>().hpTotal;
        //hpSlider.value = playerObject.gameObject.GetComponent<PlayerBehaviour>().currentHPPlayer;

        //tpSlider.maxValue = playerObject.gameObject.GetComponent<PlayerBehaviour>().tpTotal;
        //tpSlider.value = playerObject.gameObject.GetComponent<PlayerBehaviour>().currentTPPlayer;

    }
}
