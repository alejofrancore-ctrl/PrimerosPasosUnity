using Unity.VisualScripting;
using UnityEngine;

public class wincondition : MonoBehaviour
{
   [SerializeField] private UImanager _uimanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag=="Player")
        {
          Time.timeScale=0;
            _uimanager.Wincondition();
            

        }
         
    }







}
