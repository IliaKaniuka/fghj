using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fier : MonoBehaviour
{
    public float range = 0.6f;
    public Camera fpsCam;
    public GameObject fier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FierUpd();
        
    }
   public  void FierUpd()
    {
        RaycastHit hit;
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition * range);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Fier")
            {
                fier.SetActive(true);
            }if(hit.collider.tag == "Untagged")
            {
                fier.SetActive(false);
            }
                
                    
                    
        }
                
                    
                    
                    
     }
}
