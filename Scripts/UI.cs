using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnPauseGame()//暂停游戏
    {
        Time.timeScale = 0;
        ui.gameObject.SetActive(true);
    }
    public void OnContinueGame()//继续游戏
    {
        Time.timeScale = 1;
        ui.gameObject.SetActive(false);
    }
    public void OnEnd()//结束游戏
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void OnLevel1()//载入第一关
    {
        SceneManager.LoadScene("nyxd1");
        Time.timeScale = 1;
    }
}
