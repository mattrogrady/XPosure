using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSimualtor : MonoBehaviour
{
    public Light lt;
    float currentTime = 0f;
    float startingTime = 0f;
    float waitTime = 2f;
    float scrollBar = 1f;
    int result;
    public float duration = 1f;
    public AudioSource thunder;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        currentTime = startingTime;
        Time.timeScale = scrollBar;
        thunder = GetComponent<AudioSource>();
    }
    
    
    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;

        if (lt.intensity > 1)
        {
            lt.intensity = Mathf.Lerp(lt.intensity, 1, 1.5f * Time.deltaTime);
            thunder.Play();
        }
        if (currentTime > waitTime)
        {
            result = Random.Range(0, 3);
            if (result == 1)
            {
                Debug.Log("Lightning should go off now");
                float phi = Time.time / duration * 2 * Mathf.PI;
                float amplitude = Mathf.Cos(phi) * 2f + 2f;
                lt.intensity = amplitude;
            }
            currentTime -= waitTime;
            Time.timeScale = scrollBar;
        }
    }
}
