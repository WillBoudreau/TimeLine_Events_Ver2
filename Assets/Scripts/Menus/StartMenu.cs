using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject ControlMenu;
    public GameObject StartButtonObjt;
    public GameObject ControlButtonObjt;
    public GameObject QuitButtonObjt;
    // Start is called before the first frame update
    void Start()
    {
        ControlMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ControlButton()
    {
        StartButtonObjt.SetActive(false);
        ControlButtonObjt.SetActive(false);
        QuitButtonObjt.SetActive(false);
        ControlMenu.SetActive(true);
    }
}
