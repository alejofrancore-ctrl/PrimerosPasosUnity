
using UnityEngine;

public class groundcheck : MonoBehaviour
{
    public bool isground;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isground = true;
        Debug.Log("me Tocaron!! ");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isground = false;
        Debug.Log("me dejaron de tocar!!");
    }
}
