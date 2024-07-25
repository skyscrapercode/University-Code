public class BSTDisease
{
   private TreeNode a;

   public BSTDisease() 
   { 
       a = null; 
   }

   public void insertNode( Disease d )
   {
      if ( a == null )
         a = new TreeNode( d );
      else
         a.insert( d );
   }


   public void printRecords()
   { 
      inorder ( a ); 
   }
   private void inorder ( TreeNode node )
   {
      if ( node == null )
         return;

      inorder ( node.left );
      System.out.println( node.data.toString() );
      inorder ( node.right );
   }
   
   
   //Answer to question 2
   public void printAll()
   { 
      descOrder ( a ); 
   }
   private void descOrder ( TreeNode node )
   {
      if ( node == null )
         return;

      descOrder ( node.right );
      System.out.println( node.data.toString() );
      descOrder ( node.left );
   }
   
   //Answer to question 3
   public void printBySpecific ()
   {
       printBySpec ( a );
   }
   private void printBySpec(TreeNode node)
   {
       if ( node == null )
         return;
       else if (node.data.getPercentDeath() > 10)
       {
           System.out.println(node.data.toString());
           printBySpec(node.left);
           printBySpec(node.right);
       }
       else
       {
           printBySpec(node.left);
           printBySpec(node.right);
       }
   }
   
   public void calTotByYear ( int year)
   {
       System.out.println("The total percentage of death for year " + year + " is " + printBySpec ( a, year ) + "%");
   }
   private double printBySpec(TreeNode node, int year)
   {
       if ( node == null )
         return 0;
       else if (node.data.getYear() == year)
       {
           return node.data.getPercentDeath() + printBySpec(node.left, year) + printBySpec(node.right, year);
       }
       else
       {
           return printBySpec(node.left, year) + printBySpec(node.right, year);
       }
       
   }
   
   public double calByDisease ( String d)
   {
        return calculateByDisease( a, d );
   }
   
   private double calculateByDisease(TreeNode node, String d)
   {
       if ( node == null )
         return 0;
       else if (node.data.getDiseaseName().equalsIgnoreCase(d))
       {
           return node.data.getPercentDeath() + calculateByDisease(node.left, d) + calculateByDisease(node.right, d);
       }
       else
       {
           return calculateByDisease(node.left, d) + calculateByDisease(node.right, d);
       }
       
   }
   
   //v2
   
   
   
   /*
   public int calcTotQuantity()  
   { 
      return calcQuantity ( root ); 
   }
   private int calcQuantity ( TreeNode node )
   {
      if ( node == null )
         return 0;
      else
           return node.data.getQuantity() + calcQuantity(node.left) +
                                   calcQuantity(node.right);
   }
   
   public int countCompSoftware ( String comp)
   {
       return countComp ( root, comp );
   }
   private int countComp (TreeNode node, String str)
   {
    if ( node == null )
        return 0;
    else if ( node.data.getCompany().equalsIgnoreCase (str) )
        return 1 + countComp (node.left, str) +
                countComp (node.right, str);
    else
        return countComp (node.left, str) +
                countComp (node.right, str);
   } */
}

