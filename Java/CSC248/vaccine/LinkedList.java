public class LinkedList
{
    private Node head, tail, current;

    //Default LinkedList Class
    public LinkedList()                   {       head = tail = current = null;   }
    
    //To check whether is the linked list empty
    public boolean isEmpty()         {      return head == null;    }
    
    // to print data
    public String print()
    {  
      if (isEmpty())
        return "( empty list )";
      else
        return "(" + head + ")";
    }
    
    //To add new Object data at the front of the LinkedList
    public void insertAtFront(Object data)
    {
        if(isEmpty())
            head = tail = new Node(data);
        else
            head = new Node(data, head);
    }
    // Return the number of elements in the list
    public int size()
    {
        int count = 0;
        if (isEmpty())
            return count;
            
        current = head;
        while(current != null)
        {
            ++count;
            current = current.next;
        }
        return count;
    }
//To add new Object data at the back of linked list
    public void insertAtBack(Object data)
    {
        if(isEmpty())
            head = tail = new Node(data);
        else
            tail = tail.next = new Node(data);
            
    }
    
    // Return the first element in the linked list 
    public Object getFirst() throws EmptyListException
    {
        if(isEmpty())
            throw new EmptyListException();
        
        current = head;
        return current.data;
    }
   
    // Return the next element in the linked list 
    public Object getNext()
    {
        if(current != tail)
        {
            current = current.next;
            return current.data;
        }
        else
            return null;
            
    }
    
     // Return the last element in the linked list 
    public Object getLast() throws EmptyListException
    {
        if(isEmpty())
            throw new EmptyListException();
            
        return tail.data;
    }
    
    // Remove the first element in the linked list
    public Object removeFromFront() throws EmptyListException
    {
        if(isEmpty())
            throw new EmptyListException();
            
        Object d = head.data;
        
        if(head==tail)
            head=tail=null;
        else
        {
            Node curr = head;
            head = head.next;
            curr.next = null;
        }
            
        return d;
        
    }
    
    // Remove the last element in the linked list
    public Object removeFromBack() throws EmptyListException
    {
        if(isEmpty())
            throw new EmptyListException();
        
        Object d = tail.data;
        
        if(head==tail)
            head=tail=null;
        else
        {
            Node curr = head;
            while(curr.next != tail)
                curr = curr.next;
                
            tail = curr;
            curr.next = null;
        }
            
        return d;
    }
}
