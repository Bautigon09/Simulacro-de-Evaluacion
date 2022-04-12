using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    public int monto = 0;
    public string moneda;
    // Start is called before the first frame update
    void Start()
    {
        if (monto < 1000)
        {
            Debug.Log("El monto minimo es $1000");
        }
        else
        {
            switch (moneda)
            {
                case "D" : Debug.Log(monto+ " pesos equivalen a "+monto / 195+ " dolares");
                    break;
                case "R": Debug.Log(monto+ " pesos equivalen a "+monto / 24+" reales");
                    break;
                case "E": Debug.Log(monto +" pesos equivalen a "+monto / 210+ " euros");
                    break;
                default: Debug.Log("Opción de moneda extranjera no válida");
                    break;
        
                    
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
