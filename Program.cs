using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BinaryTreeProblems
{
    public class Node
    {
        public int item;
        public Node left;
        public Node right;
        public Node (int data){
            this.item=data;
            left=right=null;
        }
        public void display()
        {
            Console.Write("[");
            Console.Write(item);
            Console.Write("]");
        }
    }
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        { 
            root = null; 
        }
        public Node ReturnRoot()
        {
            return root;
        }
        
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                Console.Write(Root.item + " ");
                Inorder(Root.right);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.left);
                Postorder(Root.right);
                Console.Write(Root.item + " ");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args){
            BinaryTree tree=new BinaryTree();
            tree.root=new Node(1);
            tree.root.right=new Node(2);
            tree.root.right.left=new Node(3);
            tree.root.right.right=new Node(4);
            tree.Inorder(tree.root);
        }

       
    }

    
}