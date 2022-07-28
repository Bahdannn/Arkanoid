using UnityEngine;

public class Ball : MonoBehaviour
{
    #region Variables

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Vector2 _startDirection;

    #endregion
    #region Public methods

    public void StartMove()
    {
        _rb.velocity = _startDirection;
    }

    #endregion
   
}
