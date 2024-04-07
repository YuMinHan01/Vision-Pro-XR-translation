using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject leftController; // �޼� ��Ʈ�ѷ�
    public GameObject kMenuPrefab; // K_menu ������

    void Start()
    {
        // ��ư Ŭ�� �� ȣ��� �Լ��� ��ư�� �����մϴ�.
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeMenu);
    }

    // ��ư�� Ŭ������ �� ȣ��� �Լ�
    void ChangeMenu()
    {
        // �޼� ��Ʈ�ѷ��� �ڽ� ������Ʈ�� �����մϴ�.
        foreach (Transform child in leftController.transform)
        {
            Destroy(child.gameObject);
        }

        // K_menu �������� �޼� ��Ʈ�ѷ��� �߰��մϴ�.
        GameObject kMenu = Instantiate(kMenuPrefab, leftController.transform);
        kMenu.transform.localPosition = Vector3.zero;
    }
}
