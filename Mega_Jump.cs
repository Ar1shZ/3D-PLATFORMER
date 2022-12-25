using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mega_Jump : MonoBehaviour
{
    public float jumpVelosity = 10f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpVelosity;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 3;
    }
}