using UnityEngine;

public class SpawnerGhzivotnuh : MonoBehaviour
{
    // Массив объектов
    public GameObject[] animals;

    // Шанс для каждого объекта (чем больше число, тем выше шанс на спавн)
    public int[] chances = { 30, 20, 10, 40 }; // Например: Bear1 - 30%, Bear2 - 20%, Bear3 - 10%, Bear4 - 40%

    void Start()
    {

        InvokeRepeating(nameof(SpawnRandomAnimal), 0f, 20);
    }

    void SpawnRandomAnimal()
    {
        // Генерация случайного объекта с учётом шансов
        GameObject selectedObject = GetRandomObjectWithChance(animals, chances);

        // Вывод выбранного объекта в консоль Unity
        Debug.Log($"Выбранный объект: {selectedObject}");
        Instantiate(selectedObject, selectedObject.transform.position, selectedObject.transform.rotation);
    }

    GameObject GetRandomObjectWithChance(GameObject[] objects, int[] chances)
    {
        if (objects.Length != chances.Length)
        {
            Debug.Log("Длина массива объектов должна совпадать с длиной массива шансов.");
        }

        // Вычисляем общую сумму шансов
        int totalChance = 0;
        foreach (int chance in chances)
        {
            totalChance += chance;
        }

        // Генерируем случайное число в диапазоне от 0 до totalChance
        int randomNumber = Random.Range(0, totalChance);

        // Определяем, какой объект соответствует этому числу
        int cumulativeChance = 0;
        for (int i = 0; i < chances.Length; i++)
        {
            cumulativeChance += chances[i];
            if (randomNumber < cumulativeChance)
            {
                return objects[i];
            }
        }

        // Если что-то пошло не так
        return null;
    }
}
