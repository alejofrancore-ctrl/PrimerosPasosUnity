using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    [SerializeField] private PlayerStats _playerstats;
    [SerializeField] private GameObject _gameover;
    
   
    // Start is called before the first frame update
    void Start()
    {
        _barra.color = Color.cyan;
        _barra.fillAmount=1f;
        _gameover.SetActive(false);
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

    public void gameover()
    {
        _gameover.SetActive(true);
    }
}
