using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    private float HP = 100f;
    public Image Bar;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")

        {
            HP -= 5;
            Bar.fillAmount = HP / 100;

        }
        
    }
}
