using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[System.Serializable]
public class IntEvent : UnityEvent<int> { }

public class levelui : MonoBehaviour
{
    public Text textoNivel;
    public IntEvent onNivelCambiado;

    private void Awake()
    {
        if (onNivelCambiado == null)
            onNivelCambiado = new IntEvent();

        onNivelCambiado.AddListener(ActualizarTexto);
    }

    public void ActualizarTexto(int nivel)
    {
        textoNivel.text = "Nivel: " + nivel;
    }
}