using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireee : MonoBehaviour
{
    public GameObject fier;
    public Camera fpsCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public void Update()
    {
        if (Input.GetKey(KeyCode.E)) { 
        FireOn();
        }
    }
   private void FireOn()
    {
        RaycastHit hit;
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Fier")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    fier.SetActive(true);
                }
            
            }
        }
    }
}
