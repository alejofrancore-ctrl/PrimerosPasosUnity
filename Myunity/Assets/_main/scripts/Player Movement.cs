
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    
    [SerializeField] private float _force= 5f;
    [SerializeField] private float _speed= 5f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private groundcheck _groundcheck;
    
    private void awake()
    {
         _rigidbody2D = GetComponent<Rigidbody2D>();
    }
   
    private void FixedUpdate()
    {
        if(_groundcheck.isground)
        {
            
        
         if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * _force);
            
        }
        _rigidbody2D.velocity=Vector2.right * _speed;
    }
    }

    
    
    
   
}
