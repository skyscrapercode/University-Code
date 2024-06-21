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
            if (current.next != null) 
            {
                current = current.next;
                return current.data; 
            } 
            else 
            {
                return null; 
            }
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
    
    //Remove node anywhere in the list
    public Object removeChosenNode(int position)
    {
        //Temp is head and previous is null, previous will only need to be updated if position is more then 1
        Node temp = head, previous = null,secondPrevious = null;
        
        // If the position is the first ever node then the head will point to the next node and return the removed data, no need to loop to reach the position
        if (position == 0)
        {
            Node removedNode = head;
            head = head.getNext();
            return removedNode.getData();
        }
        
        //If the position is not the first ever node then the program will go through the linkedlist until it reaches the correct position
        //Previous and temp are equal until it reaches the position where temp will be one node infront
        for (int i = 0; i < position; i++)
        {
            previous = temp;
            temp = temp.getNext(); 
        }
        
        
        //With the location of previous we can set it to point to the next node of temp which will bypass it in the linkedlist
        if (temp == tail)
        {
            tail = previous;
        }
        else
        {
            previous.setNext(temp.getNext());    
        }
        
        //This is just to return what was removed after the loop
        return temp.getData();
    }
}
