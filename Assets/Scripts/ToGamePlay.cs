using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGamePlay : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad >= 5)
        {
            Play();
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
