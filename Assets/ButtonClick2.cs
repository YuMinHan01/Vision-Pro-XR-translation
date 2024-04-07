using UnityEngine;
using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour
{
    public GameObject prefabToSpawn; // 나타낼 프리팹
    public Transform spawnPosition; // 프리팹을 나타낼 위치

    void Start()
    {
        // 버튼의 OnClick 이벤트에 함수를 추가합니다.
        Button button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPrefab);
    }

    // 버튼이 클릭되었을 때 호출될 함수
    void SpawnPrefab()
    {
        // spawnPosition이 유효한지 확인합니다.
        if (spawnPosition != null)
        {
            // 지정된 위치에 프리팹을 생성합니다.
            Instantiate(prefabToSpawn, spawnPosition.position, spawnPosition.rotation);
        }
        else
        {
            // 오류 처리: spawnPosition이 null인 경우
            Debug.LogError("Spawn position is not assigned!");
        }
    }
}
