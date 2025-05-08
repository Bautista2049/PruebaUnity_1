using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    string palabraCorrecta = "domingo";
    public string palabra;
    // Start is called before the first frame update
    void Start()
    {
      if (palabra == palabraCorrecta)
        {
          Debug.Log("Has adivinado la palabra");
          return;
        }
      else
        {
            Debug.Log("Palabra incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
