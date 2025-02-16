using UnityEngine;

public class SpawnerGhzivotnuh : MonoBehaviour
{
    // ������ ��������
    public GameObject[] animals;

    // ���� ��� ������� ������� (��� ������ �����, ��� ���� ���� �� �����)
    public int[] chances = { 30, 20, 10, 40 }; // ��������: Bear1 - 30%, Bear2 - 20%, Bear3 - 10%, Bear4 - 40%

    void Start()
    {

        InvokeRepeating(nameof(SpawnRandomAnimal), 0f, 20);
    }

    void SpawnRandomAnimal()
    {
        // ��������� ���������� ������� � ������ ������
        GameObject selectedObject = GetRandomObjectWithChance(animals, chances);

        // ����� ���������� ������� � ������� Unity
        Debug.Log($"��������� ������: {selectedObject}");
        Instantiate(selectedObject, selectedObject.transform.position, selectedObject.transform.rotation);
    }

    GameObject GetRandomObjectWithChance(GameObject[] objects, int[] chances)
    {
        if (objects.Length != chances.Length)
        {
            Debug.Log("����� ������� �������� ������ ��������� � ������ ������� ������.");
        }

        // ��������� ����� ����� ������
        int totalChance = 0;
        foreach (int chance in chances)
        {
            totalChance += chance;
        }

        // ���������� ��������� ����� � ��������� �� 0 �� totalChance
        int randomNumber = Random.Range(0, totalChance);

        // ����������, ����� ������ ������������� ����� �����
        int cumulativeChance = 0;
        for (int i = 0; i < chances.Length; i++)
        {
            cumulativeChance += chances[i];
            if (randomNumber < cumulativeChance)
            {
                return objects[i];
            }
        }

        // ���� ���-�� ����� �� ���
        return null;
    }
}
