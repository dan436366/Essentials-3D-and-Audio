using UnityEngine;
using System.Collections;

public class extension_methods : MonoBehaviour
{

}

public static class ExtensionMethods
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}

public class SomeClass2 : MonoBehaviour
{
    void Start()
    {

        transform.ResetTransformation();
    }
}