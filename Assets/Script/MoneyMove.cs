using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMove : MonoBehaviour
{

    public float speedMoney;
  


    void Update()
    {
           
            transform.Translate(-speedMoney * Time.deltaTime, 0, 0);
    }

 

}
