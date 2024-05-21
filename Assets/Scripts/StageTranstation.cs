using UnityEngine;
using UnityEngine.SceneManagement;

public class StageTransition : MonoBehaviour
{
    // ���� ���������� �� �ε���
    public int nextStageIndex;

    private void OnTriggerEnter(Collider other)
    {
        // �÷��̾ Ʈ���ſ� �������� ��
        if (other.CompareTag("Player"))
        {
            // ���� ���������� �� �ε����� �̿��Ͽ� ��ȯ
            SceneManager.LoadScene(nextStageIndex);
        }
    }
}
