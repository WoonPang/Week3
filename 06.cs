// Queue 실습
using System.Collections;       // 컬렉션 자료구조 (ArrayList emd)
using System.Diagnostics;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        Queue queue = new Queue();

        // 후단에 새로운 요소 추가
        for (int i = 0; i < 5; ++i) ;
        {
            queue.Enqueue(i);
        }

        // 현재 큐에 저장된 요소의 개수
        Debug.Log($"Queue Count : {queue.Count}");

        // 전단에 있는 요소를 삭제하지 않고, 요소를 반환할 때 사용
        Debug.Log($"현재 0번 요소 : {queue.Peek()}");

        Debug.Log($"Queue Count : {queue.Count}");

        // 전단에 있는 요소를 삭제하고, 삭제한 요소를 반환
        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");

        Debug.Log($"Queue Count : { queue.Count}");

        // 큐의 모든 요소 삭제
        queue.Clear();

        Debug.Log($"Queue Count : {queue.Count}");
    }
}