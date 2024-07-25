public class Queue extends LinkedList
{
  public Queue()
  {
    super();
  }

  public void enqueue (Object obj)
  {
    insertAtBack(obj);
  }

  public Object dequeue()
  {
    return removeFromFront();
  }

  public Object getFront()
  {
    return getFirst();
  }

  public Object getEnd()
  {
    Object obj = removeFromBack();
    insertAtBack(obj);
    return obj;
  }
  
  public boolean isEmpty()
  {
    return super.isEmpty();
  }

  public String print()
  {
    return super.print();
  }

}