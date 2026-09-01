using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private Image barra;
    
    // Start is called before the first frame update
    void Start()
    {
        barra.color = Color.cyan;
        barra.fillAmount=0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
