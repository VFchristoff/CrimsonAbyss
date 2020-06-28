using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class EnemyHUD : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public Slider hpSlider;
    public Slider tpSlider;

    void Update()
    { 
        if (this.GetComponent<NPCMove>().currentState == TacticsMove.GameState.EnemyTurn)
        {
            UpdateUI();
        } else {
            CleanUI();
        }
    }

    public void UpdateUI()
    {

        nameText.enabled = true;
        levelText.enabled = true;
        hpSlider.enabled = true;
        tpSlider.enabled = true;

        nameText.text = this.gameObject.GetComponent<InimigoBehaviour>().classe;
        levelText.text = "Lvl " + this.gameObject.GetComponent<InimigoBehaviour>().level;

        hpSlider.maxValue = this.gameObject.GetComponent<InimigoBehaviour>().hpTotal;
        hpSlider.value = this.gameObject.GetComponent<InimigoBehaviour>().currentHPEnemy;

        tpSlider.maxValue = this.gameObject.GetComponent<InimigoBehaviour>().tpTotal;
        tpSlider.value = this.gameObject.GetComponent<InimigoBehaviour>().currentTPEnemy;
    }

    public void CleanUI() {
        nameText.enabled = false;
        levelText.enabled = false;
        hpSlider.enabled = false;
        tpSlider.enabled = false;
    }

}
