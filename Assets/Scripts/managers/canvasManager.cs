using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static canvasManager Instance { get; private set; }
    public GameObject win_panel;
    public GameObject lost_panel;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void PlayerWon()
    {
        win_panel.SetActive(true);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void PlayerLost()
    {
        lost_panel.SetActive(true);
    }
}
