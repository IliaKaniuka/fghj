using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIbt : MonoBehaviour
{
    public GameObject eat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
 
    }
    public void OnClick()
    {

        eat.SetActive(true);
    }
}
