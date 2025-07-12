using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Playerhealth playerHealth;
    public Text healthText;

    public void Start()
    {
        playerHealth.onHealthChanged.AddListener(ActualizarUI);
        ActualizarUI(); 
    }

    public void ActualizarUI()
    {
        healthText.text = "Salud: " + playerHealth.salud;
    }
}