using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseProjectManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField]
    Interactable homeButton;

    List<Interactable> chooseButtons;

    [Header("Menu Types")]
    [SerializeField]
    GameObject mainMenu;
    [SerializeField]
    GameObject projects;


    private void Start()
    {
        chooseButtons = new List<Interactable>();
        homeButton.OnClick.AddListener(Back);
        foreach(var project in projects.GetComponentsInChildren<Interactable>())
        {
            project.OnClick.AddListener(() => { Choose("1"); });
        }
    }

    private void Back()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }

    private void Choose(string id)
    {
        SceneManager.LoadScene("Main");
    }
}
