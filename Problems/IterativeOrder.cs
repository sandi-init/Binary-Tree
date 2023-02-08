using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTreeProblems.Problems
{
    public class IterativeOrder
    {
        public List<int> InOrder(Node root){
            List<int> result=new List<int>();
            Stack<Node> stack=new Stack<Node>();
            while(stack.Count!=0 || root!=null){
                if (root!=null){
                    stack.Push(root);
                    root=root.left;
                }
                else{
                    Node currNode=stack.Pop();
                    result.Add(currNode.item);
                    root=currNode.right;
                }
            }
            return result;
        }
    }
}
