//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI txt;
    int score =0;
    void Start()
    {
        txt.text=score.ToString();
    }
    public void AddCoin(int val)
    {
        score=score+val;
        Debug.Log(score);
          txt.text=score.ToString();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    public void Restart()
    {
        SceneManager.LoadScene(0);

    }
    public void Quit()
    {

        Application.Quit();
    }
}
