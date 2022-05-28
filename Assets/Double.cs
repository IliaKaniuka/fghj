using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Double : MonoBehaviour
{
    public Text fishd;
    public int fish;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            fish++;
        }
    }
}
