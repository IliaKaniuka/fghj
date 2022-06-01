using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rayc : MonoBehaviour
{
    public GameObject Image;
    public Text tcx;
    public int fish;

    void Start()
    {
        
    }

   
    void Update()
    {
        tcx.text = fish.ToString();
        if (Input.GetKey(KeyCode.Q))
        {
            Fog();
        }
    }
    private void Fog()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            fish++;
        }
    }
}
