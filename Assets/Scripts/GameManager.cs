using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Ball _ball;

    private bool _isStarted;

    #endregion
    #region Unity Lifecycle

    private void Update()
    {
        if(_isStarted)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            StartBall();
        }
    }

    #endregion
    
    #region Private methods

    private void StartBall()
    {
        Debug.Log("Start ball");
        _isStarted = true;
        _ball.StartMove();
    }
    #endregion

    #region Public methods

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    

    #endregion
    
}
