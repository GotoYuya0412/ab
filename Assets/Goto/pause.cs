using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    [SerializeField] GameObject pousepanel;
   public bool ispose = false;
    // Start is called before the first frame update
    void Start()
    {
        pousepanel.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //pousepanel.SetActive(ispose);
        //if (Input.GetKeyDown(KeyCode.Escape) && ispose == false)
        //{
        //    Time.timeScale = 0.00000001f;
        //    ispose = true;
        //    return;
        //}

        //if(Input.GetKeyDown(KeyCode.Escape) && ispose == true)
        //{
        //    Time.timeScale = 1f;

        //    ispose = false;
        //}

        //if (input.getkeydown(keycode.escape))
        //{
        //    if (ispose)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("score");
        }
    }
}
