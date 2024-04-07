using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject newPrefab; // ���ο� ������

    void Start()
    {
        // UI ��ư�� ã���ϴ�.
        Button button = GetComponent<Button>();

        // ��ư�� Ŭ�� �̺�Ʈ�� �����մϴ�.
        button.onClick.AddListener(OnButtonClick);
    }

    // ��ư Ŭ�� �̺�Ʈ �ڵ鷯
    void OnButtonClick()
    {
        // Hierarchy���� E_menu ������Ʈ�� ã���ϴ�.
        GameObject eMenu = GameObject.Find("E_menu");
        if (eMenu != null)
        {
            // E_menu ������Ʈ�� �����մϴ�.
            Destroy(eMenu);
        }

        // ���ο� �������� �����Ͽ� ���� ������Ʈ�� �ִ� ��ġ�� ��ġ�մϴ�.
        if (newPrefab != null)
        {
            Instantiate(newPrefab, eMenu.transform.position, eMenu.transform.rotation);
        }
        else
        {
            Debug.LogError("New Prefab is not assigned!"); // ���ο� �������� �Ҵ���� ���� ��� ���� �޽����� ����մϴ�.
        }
    }
}
