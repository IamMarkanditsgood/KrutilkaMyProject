using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewSphere", menuName = "ScriptableObjects/Sphere", order = 1)]
    public class ManagerScriptableObject : ScriptableObject
    {
        [SerializeField] private Color _colorSpher;
        [SerializeField] private string _scriptOnSphere;

        public Color ColorSpher => _colorSpher;
        public string ScriptOnSphere => _scriptOnSphere;
    }
}
