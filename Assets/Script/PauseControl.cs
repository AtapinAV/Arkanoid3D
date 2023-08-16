using UnityEngine;

public class PauseControl : MonoBehaviour
{
    [SerializeField] protected GameObject _menuPaused;
    [SerializeField] protected KeyCode _keyMenuPaused;
    bool _isMenuPaused = false;

    private void Start()
    {
        _menuPaused.SetActive(false);
    }

    private void Update()
    {
        OnOffPauseKey();
    }

    protected void OnOffPauseKey()
    {
        if (Input.GetKeyDown(_keyMenuPaused))
        {
            _isMenuPaused = !_isMenuPaused;
        }

        if (_isMenuPaused)
        {
            _menuPaused.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            _menuPaused.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void GameResume()
    {
        _isMenuPaused = false;
    }
}
