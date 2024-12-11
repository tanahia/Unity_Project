using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    internal void Knock()
    {
        Renderer renderer=GetComponent<Renderer>();
        renderer.material.color = Color.red;
    }
}
