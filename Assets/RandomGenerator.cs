using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    private List<int> numbers = new List<int>();
    private List<string> Letters = new List<string>();
    public void AddNumber(int number)
    {
        numbers.Add(number);
    }

    public List<int> GetRandomNumbers()
    {
        List<int> randomNumbers = new List<int>();
        if (numbers.Count < 10)
        {
            Debug.LogWarning("Not enough numbers in the list to get 10 random numbers!");
            return randomNumbers;
        }

        List<int> tempNumbers = new List<int>(numbers);//for unchanging the original list
        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, tempNumbers.Count);
            randomNumbers.Add(tempNumbers[randomIndex]);
            tempNumbers.RemoveAt(randomIndex); 
        }
        return randomNumbers;
    }

    private void Start()
    {
        for (int i = 1; i <= 20; i++)
        {
            AddNumber(i);
        }
        List<int> randomNumbers = GetRandomNumbers();
        Debug.Log("Random Numbers: " + string.Join(", ", randomNumbers));
    }
}
