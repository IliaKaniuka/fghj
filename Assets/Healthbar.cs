using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    Image healthbar;
    public float maxHealth = 100f;
    public float HP ;
    public float fill ;
    // Start is called before the first frame update
   public  void Start()
    {
        healthbar = GetComponent<Image>();
        HP = maxHealth;
        fill = 1f;
    }

    // Update is called once per frame
    public void Update()
    {
        fill -= Time.deltaTime * 0.001f;
        healthbar.fillAmount = fill;
        if (Input.GetKey(KeyCode.Alpha5))
        {
            fill += 0.0002f;
        }
    }
}
