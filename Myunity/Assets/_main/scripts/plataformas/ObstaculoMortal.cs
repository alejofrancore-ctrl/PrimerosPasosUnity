using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerstats;
    [SerializeField] private UImanager _uimanager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            _playerstats.RestarVida(10);
            _uimanager.Restarfillamount(0.1f);
            Destroy(this.gameObject);
            

        }
        
    }
}
