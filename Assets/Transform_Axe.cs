using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Axe : MonoBehaviour
{
    public Animator anim;
    public GameObject weapon;
    public GameObject weapon1;
    public GameObject weapon2;
    public int MaxWeapon = 3;
    private int ScrolInt;
    void Start()
    {
        
        
            GetComponent<Animator>();
       
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Hit");
        }
        
        if (Input.GetKeyUp(KeyCode.R))
        {
            weapon1.SetActive(false);
            weapon.SetActive(true);
        }if (Input.GetKeyUp(KeyCode.T))
        {
            weapon.SetActive(false);
            weapon1.SetActive(true);
        }if (Input.GetKeyUp(KeyCode.Escape))
        {
            weapon.SetActive(false);
            weapon1.SetActive(false);
        }
     }
}
