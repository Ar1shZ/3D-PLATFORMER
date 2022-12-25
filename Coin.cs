using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    public Text monet;
    
    int scoreMonet;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            scoreMonet++;
            other.gameObject.SetActive(false);
            monet.text = scoreMonet.ToString();
        }
    }

}
