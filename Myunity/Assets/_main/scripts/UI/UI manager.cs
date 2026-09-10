using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    [SerializeField] private PlayerStats _playerstats;
    
    // Start is called before the first frame update
    void Start()
    {
        _barra.color = Color.cyan;
        _barra.fillAmount=1f;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void Sumarfillamount(float amount)
    {
     _barra.fillAmount += amount;
     
     
    }
    public void Restarfillamount(float amount)
    {
     _barra.fillAmount -= amount;
      
    }
    public void ColorBarra(Color color)
    {
        _barra.color= color;
    }
}
