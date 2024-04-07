using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject newPrefab; // 새로운 프리팹

    void Start()
    {
        // UI 버튼을 찾습니다.
        Button button = GetComponent<Button>();

        // 버튼의 클릭 이벤트를 구독합니다.
        button.onClick.AddListener(OnButtonClick);
    }

    // 버튼 클릭 이벤트 핸들러
    void OnButtonClick()
    {
        // Hierarchy에서 E_menu 오브젝트를 찾습니다.
        GameObject eMenu = GameObject.Find("E_menu");
        if (eMenu != null)
        {
            // E_menu 오브젝트를 삭제합니다.
            Destroy(eMenu);
        }

        // 새로운 프리팹을 생성하여 이전 오브젝트가 있던 위치에 배치합니다.
        if (newPrefab != null)
        {
            Instantiate(newPrefab, eMenu.transform.position, eMenu.transform.rotation);
        }
        else
        {
            Debug.LogError("New Prefab is not assigned!"); // 새로운 프리팹이 할당되지 않은 경우 에러 메시지를 출력합니다.
        }
    }
}
