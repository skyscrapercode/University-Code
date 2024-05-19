
/**
 * Write a description of class l here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Node           // class Node is used to create a Node
{
    Object data;          
    Node link;   
    
    //Default constructor
    public Node()
    {
        data = null;
        link = null;
    }
   
    //Normal constructor
    public Node(Object data)
    {
        this.data = data;
        link = null;
    }
    
    public Node(Object data, Node next)
    {
        this.data = data;
        this.link = next;
    }
   
    //Update data
    public void setData(Object newData)
    {
        data = newData;
    }
    
    //Update the reference to the next node
    public void setNext(Node newNext)
    {
        link = newNext;
    }
    //To get the data
    public Object getData()
    {
        return data;
    }
    
    //To get the next data
    public Node getNext()
    {
        return link;
    }

    //To print
    public String toString()
    {
        if (link == null)
            return data.toString() + "";
        else 
            return data.toString() + "," + link.toString();
    }
    
}
