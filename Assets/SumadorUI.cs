using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class SumadorUI : MonoBehaviour
{
    private int num1;
    private int resultado;
    public TMP_InputField inputNum1;
    public TextMeshProUGUI textResultado;

    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarYMostrarResultado()
    {
        resultado = num1 / 2;
        num1 = int.Parse(inputNum1.text);
        if (num1 % 2 == 0)
        {
            textResultado.text = "El numero es par";
        } else
        {
            textResultado.text = "El numero es impar";
        }

    }

}
