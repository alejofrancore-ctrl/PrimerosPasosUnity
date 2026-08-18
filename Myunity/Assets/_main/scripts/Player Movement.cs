
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    
    [SerializeField] private float _jumpforce= 5f;
    [SerializeField] private float _movementspeed= 5f;
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
            _rigidbody2D.AddForce(Vector2.up * _jumpforce,ForceMode2D.Impulse) ;
            
        }
        _rigidbody2D.velocity= new Vector2(1* _movementspeed, _rigidbody2D.velocity.y);
        
    }
    }

    
    
    
   
}
