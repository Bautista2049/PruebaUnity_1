using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{ 
    public int num1;
    public int num2;
    int numMayor;
    // Start is called before the first frame update
    void Start()
    {
      if (num1 > num2)
      {
        Debug.Log("El mayor de los dos numeros ingresados es " + num1);
        return;
      };
      if (num2 > num1)
      {
        Debug.Log("El mayor de los dos numeros ingresados es " + num2);
        return;
      };
        if (num1 == num2)
        {
          Debug.Log("Son iguales");
          return;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
