using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField]
    private Interactable chooseButton;
    [SerializeField]
    private Interactable newProjectButton;
    [SerializeField]
    private Interactable quitButton;
    


    [Header("Menu Types")]
    [SerializeField]
    private GameObject newProjectMenu;
    [SerializeField]
    private GameObject chooseProjectMenu;
    void Start()
    {
        newProjectButton.OnClick.AddListener(NewProject);
        quitButton.OnClick.AddListener(Quit);
        chooseButton.OnClick.AddListener(ChooseProject);
    }

    

    private void NewProject()
    {
        newProjectMenu.SetActive(!newProjectMenu.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }

    private void ChooseProject()
    {
        chooseProjectMenu.SetActive(!chooseProjectMenu.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
