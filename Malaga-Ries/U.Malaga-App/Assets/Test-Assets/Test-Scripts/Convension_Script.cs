using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Test_Assets.Test_Scripts
{
    public class Convension_Script : MonoBehaviour
    {
        [SerializeField, Range(0, 5)] private int _isInt;
        private float isFloat;

        public string isString;
        public int IsInt() => _isInt; // expresion body

        [SerializeField, Tooltip("Enum")] private state _state;  
        [SerializeField, Tooltip("Struct")] private Test_Value _testValue;
        
        

        private void Awake() => print(Name(_isInt));

        private static string Name(int number) => (number >= 0) ? "true" : "False";
        
    }
}