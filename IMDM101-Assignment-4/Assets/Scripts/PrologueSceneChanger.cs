using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologueSceneChanger : MonoBehaviour
{
    float timer;

    void Start()
    {
        timer = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 25)
        {
            SceneManager.LoadScene("Demo Scene");
        }
    }
}
