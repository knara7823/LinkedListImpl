using System;

namespace MyApp;

public class Node<T>
{
    private T? value;

    public Node<T> next{set;get;}

    public Node<T> prev{set;get;}

    public Node(T? value)
    {
        this.value = value;
    }

    public T GetValue() =>  this.value;
    
}

public class LinkedList<T>
{
    private Node<T>? head;
    private Node<T>? tail;

    public LinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void AddLast(T value)
    {
        
        if (head == null)
        {
            head = new Node<T>(value);
            tail = head;
            return;
        }
        //4 5
        //5 previoous 4
        //4 next 5
        Node<T> node = new Node<T>(value);
        node.prev = tail;
        tail!.next = node;
        tail = node;
        
    }

    public void AddFirst(T value)
    {
        if (head == null)
        {
            head = new Node<T>(value);
            tail = head;
            return;
        }
        // 4
        // 5 4
        Node<T> node = new Node<T>(value);
        node.next = head;
        head.prev = node;
        head = node;
    }

    public void PrintNodes()
    {
        Node<T>? currentNode = this.head;

        Console.WriteLine(currentNode!.GetValue());

        while (currentNode.next != null)
        {
            currentNode = currentNode.next;
            Console.WriteLine(currentNode.GetValue());
        }
      
    }
    
    
  
}