using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons_UI : MonoBehaviour
{
    public Text fish;
    public int fishe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fish.text = fish.ToString();
        Fish();
    }
   void Fish()
    {
        fishe++;
    }
}
