using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject coin;
    public GameObject coin1;
    public GameObject coin2;
    public Text fishe;
    public int fish;
    public float range = 1.4f;
    public Camera fpsCam;
    public GameObject Image;
    public GameObject Image2;
    public GameObject Image3;
    public Text coinr;
    public int cont;
    public Text Water;
    public int wat;
    Animator anim;

 
 
    public float damage = 1f;
    public Text st;
    public int fishcnt;
    public GameObject Imag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
 public   void Update()
    {
        st.text = fishcnt.ToString();
        if (Input.GetMouseButtonDown(0))
        {


            Buy_Sold();



        }
        Water.text = wat.ToString();
        fishe.text = fish.ToString();
        coinr.text = cont.ToString();
    

       
        Polid();
        Coins();
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
                }  if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    wat++;
                    cont--;
                }  if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    fishcnt--;
                    cont++;
                } 

            }

            if (hit.collider.tag == "Untagged")
            {
                Image.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);

            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                fish--;
            }

        }

    }
    private void Coins()
    {
        RaycastHit hit;
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition * range);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Coin")
            {
                if (Input.GetKey(KeyCode.E))
                {

                    coin.SetActive(false);
                    cont++;
                }

            }
            if (hit.collider.tag == "Coin1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    coin1.SetActive(false);
                    cont++;
                }
            }
            if (hit.collider.tag == "Coin2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    coin2.SetActive(false);
                    cont++;
                }
            }



        }
    }
    private void Buy_Sold()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Woodik woodik = hit.transform.GetComponent<Woodik>();
            if (woodik != null)
            {
                woodik.TakeDamage(damage);
                fishcnt++;
            }
        }

    }

}
