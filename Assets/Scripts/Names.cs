using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names : MonoBehaviour
{
    private string name1;
    private string name2;
    void Start()
    {
        name1 = "Ogün3";
        name2 = "Mami4";

        Debug.Log(name1 + " " + name2);
        Debug.Log($"{name1} {name2.ToUpper()}");
    }
}
