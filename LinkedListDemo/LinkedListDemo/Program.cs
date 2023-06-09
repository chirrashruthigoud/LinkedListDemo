﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListNode list = new LinkedListNode();
            Console.WriteLine("select the following");
            Console.WriteLine("1.Add element to linked list.\n2.Add element in reverse.\n3.Remove First Element\n4.Remove last element" +
                "\n5.Size of LinkedList \n6.create linkedlist. \n7.Queue adding value. \n8.Queue with linked list." +
                "\n9.Add Elements to Stack. \n10.StackExample Node \n11.Linkedlsit Sorting.");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.ToDisplay();
                    break;
                case 2:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.ToDisplay();

                    break;
                case 3:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.Removeatfirst();
                    list.ToDisplay();
                    break;
                case 4:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.RemoveLast();
                    list.ToDisplay();
                    break;
                case 5:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.Size();
                    break;
             case 6:
                    LinkedlistD linkedlistD = new LinkedlistD();
                    linkedlistD.LinkedlistMethod();
                    break;
            case 7:
                QueueExample queue=new QueueExample();
                    queue.QueueMethod();
                    queue.QueueGenerics();
                    break;
                case 8:
                    QueueWithNode obj = new QueueWithNode();
                    obj.EnqueueMethod(40);
                    obj.EnqueueMethod(60);
                    obj.EnqueueMethod(80);
                    obj.DequeueMethod();
                    break;
            case 9:
                    StackExample stack=new StackExample();
                    stack.StackMethod();
                    break;
            case 10:
                    StackExampleNode name = new StackExampleNode();
                    name.PushNode(90);
                    name.PushNode(30);
                    name.PushNode(40);
                    name.PeekNode();
                    name.PopNode();
                    name.Display();
                    break;
                case 11:
                    list.Sorting(30);
                    list.Sorting(20);
                    list.Sorting(50);
                    list.ToDisplay();
                    break;

                default:
                    Console.WriteLine("Element is invalid");
                    break;
            }            
            Console.ReadLine();
        }
    }
}
