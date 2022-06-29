using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;

public class RandomGlitch : MonoBehaviour
{
    public AnalogGlitch randomGlitch;

    // Update is called once per frame
    void Update()
    {
        int randomInt = Random.Range(0, 500);
        if (randomInt == 1)
        {
            int verticalYN = Random.Range(0, 5);
            if (verticalYN == 1)
            {
                randomGlitch.verticalJump = 0.5f;
            }
            randomGlitch.scanLineJitter = 0.3f;
            randomGlitch.horizontalShake = 0.2f;
            StartCoroutine(waitCoroutine());
        }
    }

    IEnumerator waitCoroutine()
    {
        float randomSeconds = Random.Range(0.1f, 0.5f);
        yield return new WaitForSeconds(randomSeconds);
        randomGlitch.scanLineJitter = 0;
        randomGlitch.horizontalShake = 0;
        randomGlitch.verticalJump = 0;
    }
}
