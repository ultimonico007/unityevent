using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroler : MonoBehaviour
{
    public int nivelAsignado;
    public levelui LevelManager; // Debe ser levelui, no levelcontroler

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            LevelManager.onNivelCambiado.Invoke(nivelAsignado);
        }
    }
}