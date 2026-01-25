using Project;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

public class CoinsUI : MonoBehaviour
{
    [Inject] private PlayerStats _playerStats;

    public TMP_Text CoinValue;

    void Start()
    {
        CoinValue = GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        CoinValue.text = _playerStats.Coins.ToString();
    }
}