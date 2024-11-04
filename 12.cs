using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Foreach
// Hashtable, Dictionary 등과 같이 기존의 for문 활용
// 순차적으로 데이터 탐색이 불가능할 때 사용하는 반복문

foreach (데이터타입 변수명 in 배열 등 데이터 집합)
{
    // 변수명 사용
}

int[] array = new int[5] (1, 2, 3, 4, 5);
foreach ( var arr in array)
{
    Debug.Log(arr);
}

Hashtable hash = new Hashtable();
foreach ( var key in hash.Keys )
{
    Debug.Log($"Key : {key}, Value : {hash[key]}");
}