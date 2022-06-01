using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    public Text fishe;
    public int fish;
    public float range = 1.4f;
    public Camera fpsCam;
    public GameObject Image;
    public GameObject Image2;
    public GameObject Image3;
    public Text coin;
    public int cont;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
 public   void Update()
    {
        fishe.text = fish.ToString();
        coin.text = cont.ToString();

       
        Polid();
    }
    private void Polid()
    {
        RaycastHit hit;
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Work")
            {
                Image.SetActive(true);
                if (Input.GetKey(KeyCode.X))
                {
                    Image.SetActive(false);
                    Image3.SetActive(true);
                 


                }
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    fish++;
                    cont--;
                }
            }

            if (hit.collider.tag == "Untagged")
            {
                Image.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);

            }


        }

    }

}
