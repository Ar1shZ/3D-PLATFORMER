using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public int sceneID = 0;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneID);
    }
}
