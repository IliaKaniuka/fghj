using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oppen : MonoBehaviour

{
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Opn()
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
}
