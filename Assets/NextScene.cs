using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public Button yourButton;
    private int index;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        index = SceneManager.GetActiveScene().buildIndex;
        index++;
    }

    private void OnMouseDown()
    {
        index = SceneManager.GetActiveScene().buildIndex;
        if (index >= 2) { index = -1; }
        index++;
        SceneManager.LoadScene(index, LoadSceneMode.Single);
    }

    void TaskOnClick()
    {
        index = SceneManager.GetActiveScene().buildIndex;
        if(index >= 2) { index = -1; }
        index++;
        SceneManager.LoadScene(index, LoadSceneMode.Single);
    }
}
