using UnityEngine;

public class Block : MonoBehaviour
{
    #region Unity Lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }

    #endregion
}
