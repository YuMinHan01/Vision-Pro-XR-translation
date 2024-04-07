using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public XRController rightController; // 오른쪽 컨트롤러
    public GameObject leftHandPrefab; // 왼손에 들고 있는 프리팹
    public GameObject newPrefab; // 변경할 새로운 프리팹

    private XRBaseInteractable interactable;

    void Start()
    {
        // 오른쪽 컨트롤러에서 인터랙터를 가져옵니다.
        XRBaseInteractor rightInteractor = rightController.gameObject.GetComponent<XRBaseInteractor>();

        // 인터랙터의 호버 이벤트를 구독합니다.
        rightInteractor.onHoverEntered.AddListener(OnHoverEnter);

        // Canvas에서 Translation 버튼을 가져옵니다.
        Button translationButton = GetComponent<Button>();

        // 버튼의 클릭 이벤트를 구독합니다.
        translationButton.onClick.AddListener(OnButtonClick);
    }

    void OnHoverEnter(XRBaseInteractable interactable)
    {
        this.interactable = interactable;
    }

    void OnButtonClick()
    {
        // 왼손에 있는 프리팹 삭제
        Destroy(leftHandPrefab);

        // 새로운 프리팹을 생성하여 왼손에 할당
        Instantiate(newPrefab, rightController.transform.position, rightController.transform.rotation, rightController.transform);

    }
}
