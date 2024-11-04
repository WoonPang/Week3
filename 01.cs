using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Runtime.CompilerServices;

// ArrayList
private void Awake()
{
    // 컬렉션 자료구조는 선언한 변수에 메모리를 할당해야 사용할 수 있다.
    ArrayList array = new ArrayList();
    array.Add(10);

    // 요소에 접근할 떄는 첨자 연산자 []를 이용한다.
    Debug.Log(array[0]);
}