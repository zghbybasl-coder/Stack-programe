using System;
using System.Security.Cryptography.X509Certificates;
namespace Basil
{
   public class node
    {
        public object Data;
        public node Next;

      public  node(object data)
        {
            Data = data;
            Next = null;

        }


    }


    class Stack_Programe
    {
        private node top;



      public Stack_Programe()
        {

            top = null;


        }
        public void Push(object Data)
        {
            node newnode = new node(Data);
            if (top == null)
            {

                top = newnode;



            }
            else
            {
                newnode.Next = top;
                top = newnode;
            }
        }



            public object pop (object Data)
        {
          
            if (top == null) return null;
            else
            {
                
                top = top.Next;

                return top.Data;
            }
      







        }
   





        

        public void  peek()
        {

            if ( top== null) { Console.Write("My Stack is empty");      }
          
            else
            {
                Console.Write("{ ");
                node current = top;
                while (current != null) {

                    Console.Write(current.Data +" , ");

                    current = current.Next;


                }
                Console.Write(" }");

            }


        }






    }
    public class programe 
    {

        static void Main()
        {
            string name1 = "Basil";
            Stack_Programe newnode=new Stack_Programe();
            newnode.Push(10);
            newnode.Push(20);
            newnode.Push($"{name1}");
            Console.Write("My Stack :");  newnode.peek();
            newnode.pop("Basil");
            Console.WriteLine();
            Console.Write("After poping the top element :");
            newnode.peek();

           
        }






    }





}