using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private List<Button> Buttons = new List<Button>();
    [SerializeField]
    private GameObject StartMenu;
    [SerializeField]
    private GameObject CollectionPage;
    [SerializeField]
    private GameObject CreditPage;
    // Start is called before the first frame update
    void Start()
    {
        Buttons[0].onClick.AddListener(PlayGame);
        Buttons[1].onClick.AddListener(OpenCollection);
        Buttons[2].onClick.AddListener(OpenCredit);
        Buttons[3].onClick.AddListener(QuitGame);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    // Go to play scene
    void PlayGame()
    {
        SceneManager.LoadScene("");
    }
    // Open collection page
    void OpenCollection()
    {
        StartMenu.SetActive(false);
        CollectionPage.SetActive(true);
    }
    // Open credit page
    void OpenCredit()
    {

    }
    // Quit game
    void QuitGame()
    {
        Application.Quit();
    }
    // Back to start menu
    public void BackToStart()
    {
        if (CollectionPage.activeSelf)
            CollectionPage.SetActive(false);
        if (CollectionPage.activeSelf)
            CreditPage.SetActive(false);
        StartMenu.SetActive(true);
    }
}
