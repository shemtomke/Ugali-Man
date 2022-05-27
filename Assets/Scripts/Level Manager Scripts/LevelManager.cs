using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button l1, l2, l3, l4, l5;
    public int level = 1;

    private void Start()
    {
        l1.interactable = true; //default
        l2.interactable = false;
        l3.interactable = false;
        l4.interactable = false;
        l5.interactable = false;

        level = PlayerPrefs.GetInt("LVL", 1);

        switch (level)
        {
            case 1:
                l1.interactable = true;
                break;
            case 2:
                l2.interactable = true;
                break;
            case 3:
                l3.interactable = true;
                break;
            case 4:
                l4.interactable = true;
                break;
            case 5:
                l5.interactable = true;
                break;
        }
    }
    //load levels
    public void level1()
    {
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void level5()
    {
        SceneManager.LoadScene(5);
    }

    //rest levels to 1
    public void resetLvls()
    {
        PlayerPrefs.DeleteKey("LVL");
    }
}
