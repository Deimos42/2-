using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1_1
{
    class elem
    {
        public int x;
        public elem next;
        public elem prev;
    }

    public class Dec  // public class
    {
        elem head;
        elem tail;
        int count;  // public int

        public Dec() { head = null; tail = null; count = 0; }  // unsafe
        ~Dec() 
        {
        }
        public void AddN(int d)
        {
            elem temp = new elem();
            temp.next = null;
            temp.x = d;

            if (head != null)
            {
                temp.prev = tail;
                tail.next = temp;
                tail = temp;
            }
            else
            {
                temp.prev = null;
                head = tail = temp;
            }
            count += 1;
        }


        public void AddK(int s)
        {
            elem temp = new elem();
            temp.next = null;
            temp.x = s;

            if (tail != null)
            {
                temp.next = head;
                head.prev = temp;
                head = temp;
            }
            else
            {
                temp.next = null;
                head = tail = temp;
            }
            count += 1;
        }

        
        public void DelN()
        {
            elem temp = head;
            elem d;
            if (temp.next != null) 
            {
                count -= 1;
            }
            
        }
        
        

        public void Pop1()
        {
            if (tail == null)
            {
                throw new InvalidOperationException(); // исключение
            }
            else
            {
                elem temp = tail;
                if (tail.next != null)
                {
                    tail.next.prev = null;
                }
                tail = tail.next;
                count -= 1;
            }
        }

        public void DelK()
        {
        }
        public void Vivod()
        {
            elem temp = head;
            while (temp != null)  
            {
                Console.Write(temp.x);
                Console.Write(", ");
                temp = temp.next;
            }
            Console.WriteLine();
            Console.WriteLine("размер Дека: {0} ", count);       
        }
        public void Vivod2()
        {
            elem temp = tail;
            while (temp != null)  
            {
                Console.Write(temp.x);
                Console.Write(", ");
                temp = temp.prev;
            }
            Console.WriteLine();
            Console.WriteLine("размер Дека: {0} ", count);
        }

    }



    class Program
    {
        static void Main(string[] args)   
        {
            Dec L = new Dec(); 
            Dec E = new Dec();
            bool fev = true;

            while (fev == true)
            {
                Console.WriteLine("\nС каким Деком выполнять операции?(1/2)");
                string ch = Console.ReadLine();
                int ch2 = Convert.ToInt32(ch);
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1: Добавить в начало {0} Дека", ch2);
                Console.WriteLine("2: Добавить в конец {0} Дека", ch2);
                Console.WriteLine("3: Удалить из начала {0} Дека", ch2);
                Console.WriteLine("4: Удалить из конца {0} Дека", ch2);
                Console.WriteLine("5: Вывести(с конца) {0} Дек", ch2);
                Console.WriteLine("6: Вывести(с начала) {0} Дек", ch2);
                Console.WriteLine("7: Выйти");
                Console.Write("Ввод: ");
                string w = Console.ReadLine();
                int w2 = Convert.ToInt32(w);

                switch (w2)
                {
                    case 1:
                    {
                        Console.WriteLine("Введите элемент: ");
                        string el = Console.ReadLine();
                        int el2 = Convert.ToInt32(el);

                        if (ch2 == 1)
                            L.AddN(el2);
                        if (ch2 == 2)
                            E.AddN(el2);

                        break; 
                    }
                    case 2:
                    {
                        Console.WriteLine("Введите элемент: ");
                        string el = Console.ReadLine();
                        int el2 = Convert.ToInt32(el);

                        if (ch2 == 1)
                            L.AddK(el2);
                        if (ch2 == 2)
                            E.AddK(el2);

                        break; 
                    }
                    case 3:
                    {
                        if (ch2 == 1)
                            L.DelN();
                        if (ch2 == 2)
                            E.DelN();

                        break; 
                    }
                    case 4:
                    {
                        break; 
                    }
                    case 5:
                    {
                        if (ch2 == 1)
                            L.Vivod();
                        if (ch2 == 2)
                            E.Vivod();

                        //Main();
                        break; //
                    }
                    case 6:
                    {
                        if (ch2 == 1)
                            L.Vivod2();
                        if (ch2 == 2)
                            E.Vivod2();

                        //Main();
                        break; //
                    }
                    case 7:
                    {
                        fev = false;
                        break;
                    }
                }

            }                   
        }
    }
}
