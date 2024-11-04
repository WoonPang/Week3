using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 해시테이블 메소드
void Add(object, object)        // 첫 번째 매개변수를 키, 두 번째 매개변수를 값으로 사용하는 요소 추가
void Remove(object)     // 해시테이블에서 매개변수에 입력된 데이터를 키로 가지는 요소 삭제
bool ContainKey(object)     // 해시테이블에서 매개변수에 입력된 데이터를 키로 가지는 요소가 있는지 검사
bool ContainsValue(object)      // 해시테이블에서 매개변수에 입력된 데이터를 값으로 가지는 요소가 있는지 검사
ICollection Keys    // 해시테이블에 있는 모든 키 정보를 나타내는 프로퍼티
void Clear()     // 해시테이블의 모든 요소를 삭제
int Count       // 현재 해시테이블에 저장된 요소의 개수