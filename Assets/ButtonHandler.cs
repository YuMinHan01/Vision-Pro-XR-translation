using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject leftController; // 왼손 컨트롤러
    public GameObject kMenuPrefab; // K_menu 프리팹

    void Start()
    {
        // 버튼 클릭 시 호출될 함수를 버튼에 연결합니다.
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeMenu);
    }

    // 버튼을 클릭했을 때 호출될 함수
    void ChangeMenu()
    {
        // 왼손 컨트롤러의 자식 오브젝트를 삭제합니다.
        foreach (Transform child in leftController.transform)
        {
            Destroy(child.gameObject);
        }

        // K_menu 프리팹을 왼손 컨트롤러에 추가합니다.
        GameObject kMenu = Instantiate(kMenuPrefab, leftController.transform);
        kMenu.transform.localPosition = Vector3.zero;
    }
}
