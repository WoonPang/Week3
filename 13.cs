// Hashtable 실습
using System.Collections;       // 컬렉션 자료구조 (ArrayList 등)
using System.Diagnostics;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        Hashtable hash = new Hashtable();

        // 컬렉션의 자료구조는 object 타입을 저장하기 때문에 클래스 인스턴스도 저장 가능
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        // 요소 추가 ( [ ] 연산자 )
        hash["Goblin"] = goblin;

        // 요소 추가 ( Add 메소드 )
        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요. 고박사입니다.", "문자열");

        // Hashtablle, Dictionary 등과 같이 기존의 for문을 활용해
        // 순차적으로 데이터 탐색이 불간으할 때 사용하는 반복문
        // foreach ( 데이터타입 변수명 in 배열 등 데이터 집합 )
        foreach (object key in hash.Keys )
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        // 해시테이블에 "Slime" 키를 가지는 요소가 있는지 탐색
        if (hash.Containkey("Slime")) ;
        {
            Debug.Log($"Slime 키 존재")
        }

        // 해시테이블에 goblin 값을 가지는 요소가 있는지 탐색
        if ( hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        // 현재 해시테이블에 저장된 요소의 개수
        Debug.Log($"Hashtable Count : {hash.Count}");

        // 해시테이블에서 매개변수에 입력된 "Slime"을 키로 가지는 요소 삭제
        hash.Remove("Slime");

        // 현재 해시테이블에 저장된 요소의 개수
        Debug.Log($"Hashtable Count : {hash.Count}");

        // 해시테이블의 모든 요소 삭제
        hash.Clear();

        // 현재 해시테이블에 저장된 요소의 개수
        Debug.Log($"Hashtable Count : {hash.Count}");
    }
}

public class Goblin { }

public class Slime { }