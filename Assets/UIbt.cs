using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIbt : MonoBehaviour
{
    public Image eat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (eat.enabled == false) {

            OnClick();
        }

    }
    public void OnClick()
    {

        eat.enabled = true;
    }
}
