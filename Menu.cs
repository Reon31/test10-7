using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;

    void Start()
    {
        pausePanel.SetActive(false);
        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
    }

    public void Pause()
    {
        Time.timeScale = 0;//時間停止
        pausePanel.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1;//再開
        pausePanel.SetActive(false);
    }
}
