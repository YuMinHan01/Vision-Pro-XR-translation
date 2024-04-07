using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public XRController rightController; // ������ ��Ʈ�ѷ�
    public GameObject leftHandPrefab; // �޼տ� ��� �ִ� ������
    public GameObject newPrefab; // ������ ���ο� ������

    private XRBaseInteractable interactable;

    void Start()
    {
        // ������ ��Ʈ�ѷ����� ���ͷ��͸� �����ɴϴ�.
        XRBaseInteractor rightInteractor = rightController.gameObject.GetComponent<XRBaseInteractor>();

        // ���ͷ����� ȣ�� �̺�Ʈ�� �����մϴ�.
        rightInteractor.onHoverEntered.AddListener(OnHoverEnter);

        // Canvas���� Translation ��ư�� �����ɴϴ�.
        Button translationButton = GetComponent<Button>();

        // ��ư�� Ŭ�� �̺�Ʈ�� �����մϴ�.
        translationButton.onClick.AddListener(OnButtonClick);
    }

    void OnHoverEnter(XRBaseInteractable interactable)
    {
        this.interactable = interactable;
    }

    void OnButtonClick()
    {
        // �޼տ� �ִ� ������ ����
        Destroy(leftHandPrefab);

        // ���ο� �������� �����Ͽ� �޼տ� �Ҵ�
        Instantiate(newPrefab, rightController.transform.position, rightController.transform.rotation, rightController.transform);

    }
}
