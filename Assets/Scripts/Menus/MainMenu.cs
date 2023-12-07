using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject ControlButton;
    [SerializeField] private GameObject QuitButton;
    [SerializeField] private GameObject ControlMenu;
    [SerializeField] private GameObject ControlBackButton;
    // Start is called before the first frame update
    void Start()
    {
        ControlMenu.SetActive(false);
        ControlBackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SrtButn()
    {
        SceneManager.LoadScene(0);
    }
    public void CotrlButn()
    {
        ControlMenu.SetActive(true);
        ControlBackButton.SetActive(true);
    }
    public void CotrlButnBck()
    {
        ControlMenu.SetActive(false);
        ControlBackButton.SetActive(false);
    }
}
