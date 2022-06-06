using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open_Close_Box : MonoBehaviour
{ public Text txt;
    Animator anim;
    public GameObject image;
    public GameObject image2;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.Tab))
        {
          
            image.SetActive(true);
           
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
          
            image.SetActive(false);
          
        }
 
      
    }
 
}
