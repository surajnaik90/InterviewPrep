/*
Design and implement a data structure for Least Recently Used (LRU) cache. 
It should support the following operations: get and set.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
set(key, value) - Set or insert the value if the key is not already present. 
When the cache reaches its capacity, it should invalidate the least recently used item before inserting the new item.
The LRUCache will be initialized with an integer corresponding to its capacity. 
Capacity indicates the maximum number of unique keys it can hold at a time.

Definition of "least recently used" : An access to an item is defined as a get or a set 
operation of the item. "Least recently used" item is the one with the oldest access time.

NOTE: If you are using any global variables, make sure to clear them in the constructor.

Example :

Input : 
         capacity = 2
         set(1, 10)
         set(5, 12)
         get(5)        returns 12
         get(1)        returns 10
         get(10)       returns -1
         set(6, 14)    this pushes out key = 5 as LRU is full. 
         get(5)        returns -1 
 */

using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class DLLNode
{
    public DLLNode prev;
    public DLLNode next;
    public int key;

    public DLLNode(int key)
    {
        this.key = key;
        this.prev = null;
        this.next = null;
    }
}

public class LRUCache
{
    static DLLNode cache = null;
    static DLLNode head;
    static DLLNode tail;
    static int capacity;
    static Dictionary<int, DLLNode> caches = new Dictionary<int, DLLNode>();
    static Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
    public LRUCache(int capacity)
    {
        LRUCache.capacity = capacity;
        cache = null;
        head = null;
        tail = null;
        caches.Clear();
        keyValuePairs.Clear();
    }

    public int get(int key)
    {
        if (caches.ContainsKey(key)) {
            DLLNode node = caches[key];
            deleteNode(node);
            insertNode(node);

            return keyValuePairs[key];
        }
        else {
            return -1;
        }
    }

    public void set(int key, int value)
    {
        if (keyValuePairs.Count < LRUCache.capacity) {

            if (!caches.ContainsKey(key)) {
                
                keyValuePairs.Add(key, value);
                DLLNode node = new DLLNode(key);
                insertNode(node);
                caches.Add(key, node);
            }
        }
        else {

            int headKey = head.key;
            keyValuePairs.Remove(headKey);
            deleteNode(head);

            keyValuePairs.Add(key, value);
            DLLNode node = new DLLNode(key);
            insertNode(node);
            caches.Add(key, node);
        }
    }

    public static void deleteNode(DLLNode node)
    {
        if (node.prev != null) {
            node.prev.next = node.next;
        }
        else {
            head = node;
        }

        if (node.next != null) {
            node.next.prev = node.prev;
        }
        else {
            tail = node.prev;
        }
    }

    public static void insertNode(DLLNode node)
    {
        if (tail == null || head == null) {
            tail = node;
            head = node;
            cache = node;
        }
        else {
            tail.next = node;
            node.prev = tail;
            tail = tail.next;
        }
    }
}