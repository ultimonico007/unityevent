using UnityEngine;
using UnityEngine.UI;

public class inventorydisplay : MonoBehaviour
{
    public Inventory inventario;
    public Text textoInventario;

    void Start()
    {
        inventario.onInventoryChanged.AddListener(ActualizarTexto);
        ActualizarTexto(); 
    }

    public void ActualizarTexto()
    {
        textoInventario.text = "Objetos: " + inventario.cantidadObjetos;
    }
}