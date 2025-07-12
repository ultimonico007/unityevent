using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject panelDialogo;
    public Text textoDialogo;
    public string mensaje;

    public void MostrarDialogo()
    {
        panelDialogo.SetActive(true);
        textoDialogo.text = mensaje;
    }
}