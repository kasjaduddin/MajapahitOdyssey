using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TESController : MonoBehaviour
{
    [SerializeField]
    private GameObject StartMenu;

    public void open()
    {
        StartMenu.SetActive(true);
    }
    
}
