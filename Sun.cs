using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Sun : MonoBehaviour
{

    public Light sun;
    public float changeRotate;
    public float factorRotate = 0.00000000001f;

    void Start()
    {
        changeRotate = sun.GetComponent<Transform>().rotation.x;
        StartCoroutine(UWU());
    }

    private IEnumerator UWU()
    {
        while (true)
        {
            yield return new WaitForSeconds(20);
            changeRotate += factorRotate;
            sun.transform.Rotate(changeRotate, 0, 0);
            Debug.Log(changeRotate);

            if (changeRotate % 1f == 1f)
            {
                yield return new WaitForSeconds(20);
                Debug.Log(changeRotate);
                yield return new WaitForSeconds(20);
            }
            yield return new WaitForSeconds(20);
        }
    }
}
