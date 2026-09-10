
using UnityEngine;

public class curar : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerstats;
    [SerializeField] private UImanager _uimanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            _playerstats.SumarVida(10);
            _uimanager.Sumarfillamount(0.1f);
            Destroy(this.gameObject);
        }

    }
    //detectar colisiones
    //detectar el tag de Player
    //sumar puntos de vida
    //desturirse
}
