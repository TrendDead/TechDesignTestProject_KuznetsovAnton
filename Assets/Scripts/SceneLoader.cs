using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Загрцзчик сцен
/// </summary>
[RequireComponent(typeof(Button))]
public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private int _indexLoadScene;

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(LoadScene);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(LoadScene);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(_indexLoadScene);
    }
}
