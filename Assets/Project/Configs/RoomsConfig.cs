using UnityEngine;

[CreateAssetMenu(
    fileName = "RoomConfig",
    menuName = "Configs/Room"
)]
public class RoomConfig : ScriptableObject
{
    public GameObject roomPrefab;


    public int difficulty;
    public int weight = 1;

    public bool doorUp;
    public bool doorDown;
    public bool doorLeft;
    public bool doorRight;
}