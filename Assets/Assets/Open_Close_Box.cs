using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open_Close_Box : MonoBehaviour
{ public Text txt;
    Animator anim;
    public GameObject image;
    public GameObject image2;
    public Text wood;
    public int wer;
    // Start is called before the first frame update
 

    // Update is called once per frame
   public void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            image.SetActive(true);
            GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;

        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {

            image.SetActive(false);
            GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;

        }
    }
  
 public void Open()
    {

    }
}
