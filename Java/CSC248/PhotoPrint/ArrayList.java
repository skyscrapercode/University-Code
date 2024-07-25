public class ArrayList
{
    private Object[] data;
    private int length, maxSize;
    
    //Default constructor
    public ArrayList()
    {
        maxSize = 0;
        data = null;
        length = 0;
    }

    //Normal constructor
    public ArrayList(int k)
    {
        maxSize = k;
        data = new Object[maxSize];
        length = 0;
    }

    // Return the size of the array list
    public int getMaxSize() 
    {
        return maxSize;   
    }

    // Return the number of elements in the array list
	public int getNum() 
    {
        return length;   
    }

    // Insert an element at the back of the array list
    public void insertEnd(Object k) throws ArrayListException
    {
       if(!isFull())
       {
          data[length] = k;
          length = length + 1;
       }else
          throw new ArrayListException("The Array List is full");
    }
    
    // Insert an element at the front of the array list
    public void insertFront(Object k) throws ArrayListException
    {
        add(0,k);
     }
    //Insert an element at anywhere of the array list
    public void add(int i, Object k) throws ArrayListException
    {
        if(isFull())
           throw new ArrayListException("The Array List is full");
        else if ((i < 0) || (i > length))
           throw new ArrayListException("Index is out of bounds"); 
        else
        {
            
            for(int j = length-1; j >= i; --j)
                data[j + 1] = data[j];
                
            length = length + 1;
            data[i] = k;
            
        }
    }
       
    //Return data at the specified location
    public Object getData(int i) throws ArrayListException
    {
       if (isEmpty())
           throw new ArrayListException("The Array List is empty");
        else if((i < 0) || (i > length-1))
           throw new ArrayListException("Index is out of bounds");
            
        return data[i];   
    }


    // Set data at the specified location
    public void setData(int i, Object k) throws ArrayListException
    {
        if (isEmpty())
           throw new ArrayListException("The Array List is empty");
        else if((i < 0) || (i > length-1))
           throw new ArrayListException("Index is out of bounds");
        
        data[i] = k;   
    }

        // Remove data at the specified location
    public Object removeAt(int i) throws ArrayListException
    {
        if (isEmpty())
           throw new ArrayListException("The Array List is empty");
        else if((i < 0) || (i > length-1))
           throw new ArrayListException("Index is out of bounds");
           
        if ( i == (length-1))
        {
            length = length - 1;
            return data[i];
        }
        
        Object obj = data[i];
        for(int j = i; j < length - 1; ++j)  
        {
            data[j] = data[j+1];
        }
        
        length = length - 1;
        return obj;   
    }
    

    // Remove the first element
    public Object removeFirst() throws ArrayListException
    {
        return removeAt(0);   
    }
    
    // Remove the last element
    public Object removeLast() throws ArrayListException
    {
        return removeAt(length-1);
    }
    
    // Clear all the elements in the Array List
    public void clearList() 
    {
        length = 0;   
    }
    

    // Return true if the Array List is full otherwise return false
    public boolean isFull()
    {
        return length == maxSize;   
    }
    
    // Return true if the Array List is empty otherwise return false
    public boolean isEmpty() 
    {
        return length == 0;   
    }

    // for displaying the element in the Array List
    public String print(){ 
        String str ="(";
        if (length == 0)
            return "( )";
        else 
        {
            for(int i = 0; i < length; ++i)
                str += data[i]+",";
            return str+")";
        }
    }  
}