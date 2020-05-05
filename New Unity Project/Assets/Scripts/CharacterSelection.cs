using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private int selectedCharacterIndex;
    private readonly string selectedCharacter = "SelectedCharacter";
    private Color desiredColor;
    LevelLoader LevelLoader;
    
    [Header("List of Characters")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();
    
    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColor;

    [Header("Tweaks")]
    [SerializeField] private float backgroundColorTransitionSpeed = 10.0f;
    public void Start()
    {
        UpdateCharacterSelectionUI();
    }

    private void Update() 
    {
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);
    }

    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if(selectedCharacterIndex < 0)
        selectedCharacterIndex = characterList.Count - 1;

        UpdateCharacterSelectionUI();
    }

    public void RightArrow()
    {
        selectedCharacterIndex++;
        if(selectedCharacterIndex == characterList.Count)
        selectedCharacterIndex = 0;

        UpdateCharacterSelectionUI();
    }

    public void Confirm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        LevelLoader.LoadNextLevel();
    }

    private void UpdateCharacterSelectionUI()
    {
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
        characterName.text = characterList[selectedCharacterIndex].characterName;
        desiredColor = characterList[selectedCharacterIndex].characterColor;
    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public Color characterColor;
    }


}
