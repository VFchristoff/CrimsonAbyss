using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class CharacterSelection : MonoBehaviour
{
    public List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();
    public int selectedCharacterIndex;
    private Color desiredColor;
    public TextMeshProUGUI characterName;
    public Image characterSplash;
    public Image backgroundColor;
    public TextMeshProUGUI characterClass;
    public TextMeshProUGUI characterDescription;

    public float backgroundColorTransitionSpeed = 10f;
    public AudioClip arrowClickSFX;
    public AudioClip characterSelectMusic;

    public void Start ()
    {
        UpdateCharacterSelectionUI();
    }

    public void UpdateCharacterSelectionUI ()
    {
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
        characterClass.text = characterList[selectedCharacterIndex].characterClass;
        characterName.text = characterList[selectedCharacterIndex].characterName;
        characterDescription.text = characterList[selectedCharacterIndex].characterDescription;
        //backgroundColor.GetComponent<Image>().color = characterList[selectedCharacterIndex].characterColor;
        backgroundColor.color = characterList[selectedCharacterIndex].characterColor;
        //desiredColor = characterList[selectedCharacterIndex].characterColor;

    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public string characterClass;
        public string characterDescription;
        public Color characterColor;
    }

    public void LeftArrow ()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
        {
            selectedCharacterIndex = characterList.Count - 1;
        }
        UpdateCharacterSelectionUI();
    }
    public void RightArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
        {
            selectedCharacterIndex = 0;
        }
        UpdateCharacterSelectionUI();
    }
    public void Update ()
    {
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);

    }
}
