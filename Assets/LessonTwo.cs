using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonTwo : MonoBehaviour
{
    internal class Program
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                UnityEngine.Debug.Log($"{street}, {number}");
            }
        }
        static void Main(string[] args)
        {
            House tower = new House();
            tower.street = "Красная";
            tower.number = 50;

            tower.Print();

        }
    }
}
