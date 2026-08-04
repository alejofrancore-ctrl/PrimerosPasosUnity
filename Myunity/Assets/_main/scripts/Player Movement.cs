
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    
    public float altura= 1.67f;
    public int edad=18;
    public string nombre = "Alejo";
    public bool puedeVotar= true;
    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform transform;
    
    // crear variable de tipo transform
    private void Start()
    {
        Debug.Log("Hola "+ nombre + " tu edad es "+ edad + " tu altura es: " + altura);
         rigidbody2D.simulated = false;
         spriteRenderer.color =Color.blue;
         //llamo la variable y le asigno valor en x de 10
         transform.position= new Vector3(10,0,0);
    }
    private void Update()
    {
        
    }
    
    
   
}
