using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Input.GetButtonDown(Button.One);
       // myLight = GetComponent<Light>()
    }

    // Update is called once per frame
    void Update()
    {   
       /* if (some seconds pass) {
            myLight.intensity = X
        }

        if (button down is presed) {
           */  
        // if (OVRInput.GetDown(OVRInput.Button.One))
        if (Input.GetButtonDown("Fire1"))
        // if (Input.GetButtonDown(Button.One))
        {
            Debug.Log("Loading fear of heights simulator");
            SceneManager.LoadScene("_Heights", LoadSceneMode.Single);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Loading fear of lightning/thunder simulator");
            SceneManager.LoadScene("_Thunder", LoadSceneMode.Single);
        }
    }
}
