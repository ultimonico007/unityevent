using UnityEngine;
using UnityEngine.UI;

public class gameUI : MonoBehaviour
{
    public GameObject panelPausa;

    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
    }

    public void OcultarPausa()
    {
        panelPausa.SetActive(false);
    }
}