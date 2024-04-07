using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabObject : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        // XRGrabInteractable ������Ʈ�� ã���ϴ�.
        grabInteractable = GetComponent<XRGrabInteractable>();

        // XRGrabInteractable ������Ʈ�� ���ٸ� ����� ǥ���ϰ� �����մϴ�.
        if (grabInteractable == null)
        {
            Debug.LogError("XRGrabInteractable component not found.");
            enabled = false;
            return;
        }

        // ������Ʈ�� �׷��Ǿ��� ���� �̺�Ʈ�� �̺�Ʈ �ڵ鷯�� �߰��մϴ�.
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
    }

    // ������Ʈ�� �׷��Ǿ��� �� ȣ��Ǵ� �ݹ� �Լ�
    private void OnGrabbed(XRBaseInteractor interactor)
    {
        // �׷��� ������ ��Ʈ�ѷ��� Transform�� ������Ʈ�� �θ�� �����մϴ�.
        transform.parent = interactor.transform;
    }
}
