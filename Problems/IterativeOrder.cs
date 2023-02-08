using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTreeProblems.Problems
{
    public class postorder{
        public Node node;
        public bool isChild;
    }
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
        public List<int> PreOrder(Node root){
            List<int> result=new List<int>();
            Stack<Node> stack=new Stack<Node>();
            while(stack.Count!=0 || root!=null){
                if (root!=null){
                    stack.Push(root);
                    result.Add(root.item);
                    root=root.left;
                }
                else{
                    Node currNode=stack.Pop();
                    root=currNode.right;
                }
            }
            return result;
        }
        public List<int> PostOrder(Node root){
            List<int> result=new List<int>();
            Stack<postorder> stack=new Stack<postorder>();
            postorder newval=new postorder{node=root,isChild=false};
            stack.Push(newval);
            while(stack.Count!=0){
                postorder curVal=stack.Pop();
                if(curVal.isChild){
                    result.Add(curVal.node.item);
                }
                else{
                    stack.Push(new postorder{node=curVal.node,isChild=true});
                    if(curVal.node.right!=null){
                        stack.Push(new postorder{node=curVal.node.right,isChild=false});
                    }
                    if(curVal.node.left!=null){
                        stack.Push(new postorder{node=curVal.node.left,isChild=false});
                    }
                }
            }
            return result;
        }
        
    }
}
