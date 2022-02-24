using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioClip _buttonPress;
    [SerializeField] private GameObject _menu;

    public void ContiniueGame()
    {
        PlayMusic();
        Time.timeScale = 1;
        _menu.SetActive(false);
    }

    public void ReturnMenu()
    {
        PlayMusic();
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        PlayMusic();
        Application.Quit();
    }

    private void PlayMusic()
    {
        GetComponent<AudioSource>().PlayOneShot(_buttonPress);
    }
}