using Project;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

public class BombsUI : MonoBehaviour
{
    [Inject] private PlayerStats _playerStats;

    public TMP_Text BombsValue;

    void Start()
    {
        BombsValue = GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        BombsValue.text = _playerStats.Bombs.ToString();
    }
}