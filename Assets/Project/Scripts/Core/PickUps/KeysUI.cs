using Project;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

public class KeysUI : MonoBehaviour
{
    [Inject] private PlayerStats _playerStats;

    public TMP_Text KeysValue;

    void Start()
    {
        KeysValue = GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        KeysValue.text = _playerStats.Keys.ToString();
    }
}
