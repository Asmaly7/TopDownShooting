using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    private float _timesinceLastAttack = float.MaxValue;

    protected bool IsAttacking { get; set; }

    protected virtual void update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        if (_timesinceLastAttack <= 0.2f)
        {
            _timesinceLastAttack += Time.deltaTime;
        }

        if(IsAttacking && _timesinceLastAttack > 0.2f)
        {
            _timesinceLastAttack = 0;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); 
        
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }
}











//    //[SerializeField] private float speed = 5f;
//    // Start is called before the first frame update
//    //void Start()
//  //  {
//  //      
//  //  }

//    // Update is called once per frame
//    void Update()
//    {
//        //float x = Input.GetAxisRaw("Horizontal");
//        //float y = Input.GetAxisRaw("Vertical");

//        //transform.position += new Vector3(x, y) * Time.deltaTime;
//    }
//}
