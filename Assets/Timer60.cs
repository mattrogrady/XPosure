using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer60 : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        if (currentTime >= 40)
        {
            Debug.Log("Returning to main directory");
            SceneManager.LoadScene("_Menu", LoadSceneMode.Single);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene("_Menu", LoadSceneMode.Single);
        }
    }
}
