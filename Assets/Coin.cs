using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text fish;
    public int fishe;
    public GameObject Button;
    public float range = 1f;
    public Camera fpsCam;
    public GameObject coin;
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public int Coincnt;
    public Text goin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        goin.text = Coincnt.ToString();
        fish.text = fishe.ToString();

        Coins();
     
    }
    private void Coins()
    {
        RaycastHit hit;
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition * range);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Coin")
            {
                if (Input.GetKeyDown(KeyCode.E)) { 

                coin.SetActive(false);
                    Coincnt++;
                }
               
            }
            if (hit.collider.tag == "Coin1")
            {
                if (Input.GetKeyDown(KeyCode.E)) { 

                coin1.SetActive(false);
                    Coincnt++;
                }
            }if (hit.collider.tag == "Coin2")
            {
                if (Input.GetKeyDown(KeyCode.E)) { 

                coin2.SetActive(false);
                    Coincnt++;
                }
            }
      


        }
    }
}

