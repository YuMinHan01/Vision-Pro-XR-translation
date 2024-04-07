using UnityEngine;
using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour
{
    public GameObject prefabToSpawn; // ��Ÿ�� ������
    public Transform spawnPosition; // �������� ��Ÿ�� ��ġ

    void Start()
    {
        // ��ư�� OnClick �̺�Ʈ�� �Լ��� �߰��մϴ�.
        Button button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPrefab);
    }

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �Լ�
    void SpawnPrefab()
    {
        // spawnPosition�� ��ȿ���� Ȯ���մϴ�.
        if (spawnPosition != null)
        {
            // ������ ��ġ�� �������� �����մϴ�.
            Instantiate(prefabToSpawn, spawnPosition.position, spawnPosition.rotation);
        }
        else
        {
            // ���� ó��: spawnPosition�� null�� ���
            Debug.LogError("Spawn position is not assigned!");
        }
    }
}
