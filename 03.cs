// ArrayList 실습
using System.Collections;       // 컬렉션 자료구조 (ArrayList 등)
using System.Collections.ObjectModel;       // Collection 클래스
using System.Diagnostics;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        ArrayList arrayList = new ArrayList();

        // 요소 추가 (순차)
        // object 타입이기 때문에 여러 종류의 데이터 저장 가능
        Debug.Log(arrayList.Add(10));
        // Debug.Log(arrayList.Add(12.3f);
        // Debug.Loh(arrayList.Add("안녕하세요. 고박사입니다."));

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 추가 (원하는 위치)
        arrayList.Insert(1, 100);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 추가 (범위, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 데이터 정렬 (ArrayList에 정수 데이터만 있을 때 한정으로 사용 가능)
        // 그 외 데이터가 들어있을 경우 에러 발생
        arrayList.Sort();

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 삭제 (매개변수에 입력된 데이터)
        arrayList.Remove(10);

        // 데이터 출력
        PrintArrayLisr(arrayList);

        // 요소 삭제 (매개변수에 입력된 위치의 요소)
        arrayList.RemoveAt(0);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 삭제 (첫 번째 매개변수 위치부터 두 번째 매개변수 개수만큼 삭제)
        arrayList.RemoveRange(0, 2);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 모든 요소 삭제
        arrayList.Clear();

        // 요소 개수 출력
        Debug.Log(arrayList.Count);
    }

    public void PrintArrayList(ArratList list)
    {
        Debug.Log("======================");

        for (int i = 0; i < list.Count; ++i)
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
}