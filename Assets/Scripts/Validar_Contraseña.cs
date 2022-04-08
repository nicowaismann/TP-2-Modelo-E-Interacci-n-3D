using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validar_Contraseña : MonoBehaviour { 

    string ContraseniaCorrecta;
    string ContraseniaUsuario;
    public Text IngresoUsuario;
    public GameObject CartelMensaje;
    public Text TextoMensaje;

    // Start is called before the first frame update
    void Start()
    {

        ContraseniaCorrecta = "12345";
        CartelMensaje.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    public void validarContraseña()
    {

        

        ContraseniaUsuario = IngresoUsuario.text;

        if(ContraseniaUsuario == ContraseniaCorrecta)
        {
            CartelMensaje.SetActive(true);
            TextoMensaje.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            CartelMensaje.SetActive(true);
            TextoMensaje.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
