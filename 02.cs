using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ArrayList 메소드
int Add(object)     // 마지막 요소 뒤에 새로운 요소 추가
void Insert(int, object)        // 첫 번째 매개변수 위치에 두 번째 매개변수 요소 추가
void AddRange(ICollection)      // 여러 개의 요소를 한꺼번에 추가
void Remove(object)     // 매개변수에 입력된 데이터와 동일한 데이터 요소 삭제
void RemoveAt(int)      // 매개변수에 입력된 위치의 요소 삭제
void RemoveRange(int, int)      // 첫 번째 매개변수 위치부터 두 번째 매개변수 개수만큼의 요소 삭제
void Sort()     // ArrayList 내의 요소를 오름차순으로 정렬
void Clear()        // 모든 요소를 삭제해 ArrayList를 초기화
int Count       // 현재 ArrayList에 저장되어 있는 요소의 개수