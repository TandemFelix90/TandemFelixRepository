using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;
    // это мы создали внутри класса Player хранится экземпляр класса Player. Итого он сам к себе обращается. 
    //Дальше создаем метод GetPosition
    private void Start()
    {
        instance = this;
        //присваиваю переменной instance себя (плеера)
    }
    public static Vector3 GetPosition()
    //позиция в трехмерном пространстве прописывается vector3
    {
        //возвращаем позиции компонента трансформа текущего объекта.  Но у нас не
        //получится, так как это запрещено именно компонент с маленькой буквы, именно //поэтому мы создавали instance
        return instance.transform.position;
    }
    public static void SetPosition(Vector3 position)
    {
        instance.transform.position = new Vector3(position.x, 0.0f, position.z);
        //к нам приходит значение позтиции из Vector3 position сверху и мы берем контроль последней строкой на себя, создаем новый вектор и так далее  А У обнуляем
    }
}
