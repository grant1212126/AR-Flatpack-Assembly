using System.Collections;
using System.Collections.Generic;
using Riptide;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _singleton;

    public static UIManager Singleton
    {
        get => _singleton;
        private set
        {
            if (_singleton == null)
            {
                _singleton = value;
            }
            else if (_singleton != value)
            {
                Debug.Log($"{nameof(UIManager)} instance already exists, destroying duplicate");
                Destroy(value);
            }
        }
    }

    [Header("Connect")]
    [SerializeField] private GameObject connectUI;
    [SerializeField] private ProgressBar ProgressBar;

    private void Awake()
    {
        Singleton = this;
    }

    public void ConnectClicked()
    {
        connectUI.SetActive(false);

        NetworkManager.Singleton.Connect();
    }

    public void BackToMain()
    {
        connectUI.SetActive(true);
    }

    public void TestProgressBar()
    {
        ProgressBar.ChangeProgressBar(0.5f);
    }
}
