﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    public class HashTableExam
    {
        //HashTable은 key와 value의 쌍을 가진 집합 자료구조
        public Hashtable map = new Hashtable();

        public void test()
        {
            map.Add(1, "kim");
            map.Add(2, "lee");
            map[3] = "park";    //key, value의 쌍으로 데이터 추가

            //Hashtable은 Generic을 명시하지 않아 object형태로 데이터를 가져온다. 캐스팅이 필요
            Console.WriteLine((string)map[1]);  //키를 통해 데이터를 가져옴
            Console.WriteLine((string)map[2]);  //키를 통해 데이터를 가져옴
            Console.WriteLine((string)map[3]);  //키를 통해 데이터를 가져옴
        }
    }
}
