using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewProjectManager : MonoBehaviour
{
    [Header("Input")]
    [SerializeField]
    private TextMeshPro inputText;
    [SerializeField]
    private TextMeshPro finalText;

    [Header("Buttons")]
    [SerializeField]
    Interactable homeButton;
    [SerializeField]
    Interactable createButton;

    [Header("Menu Types")]
    [SerializeField]
    GameObject mainMenu;


    private void Start()
    {
        finalText.text = inputText.text;

        homeButton.OnClick.AddListener(Back);
        createButton.OnClick.AddListener(Create);
    }

    private void Back()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }

    private void Create()
    {
        SceneManager.LoadScene("Main");
    }

}
