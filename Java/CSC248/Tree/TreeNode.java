class TreeNode
{
   TreeNode left;       // left node
   Disease data;       // data item
   TreeNode right;      // right node

   public TreeNode( Disease d )
   { 
      data = d;              
      left = right = null; 
   }

   public void insert( Disease d )
   {
      if ( d.getPercentDeath() < data.getPercentDeath() ) 
      {
         if ( left == null )
            left = new TreeNode( d );
         else
            left.insert( d );
      }
      else if ( d.getPercentDeath() > data.getPercentDeath() ) 
      {
         if ( right == null )
            right = new TreeNode( d );
         else
            right.insert( d );
      }
   }
}