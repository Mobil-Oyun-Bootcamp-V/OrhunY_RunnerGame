using System;
using UnityEngine;

namespace Chibi.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private Animator _anim;
        
        public float speed = 200f;

        private void FixedUpdate()
        {
            if (GameManager._currentState != GameManager.States.UI)
            {
                _rb.velocity = Vector3.forward * (speed * Time.fixedDeltaTime);
            }
        }
    }
}