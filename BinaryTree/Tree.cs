using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        private Node root;
        public Tree()
        {
            root = null;
        }
        public Node find(int key)
        {
            Node current = root;
            while (current.id != key)
            {
                if (key < current.id)
                {
                    current = current.leftChild;
                }
                else
                {
                    current = current.rightChild;
                }
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }
        public void insert(int id, String data)
        {
            Node newNode = new Node();
            newNode.id = id;
            newNode.data = data;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.id)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;

                            return;

                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;

                            return;

                        }
                    }
                }
            }
        }
        public bool delete(int key)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;
            while (current.id != key)
            {
                parent = current;
                if (key < current.id)
                {
                    isLeftChild = true;
                    current = current.leftChild;
                }
                else
                {
                    isLeftChild = false;
                    current = current.rightChild;

                }
                if (current == null)
                {
                    return false;
                }
            }
            if (current.leftChild == null
            && current.rightChild == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else if (isLeftChild)
                {
                    parent.leftChild = current.leftChild;
                }
                else
                {
                    parent.rightChild = current.leftChild;
                }
            }
            else if (current.rightChild == null)
            {
                if (current == root)
                {
                    root = current.leftChild;
                }
                else if (isLeftChild)
                {
                    parent.leftChild = current.leftChild;
                }
                else
                {
                    parent.rightChild = current.leftChild;
                }
            }
            else if (current.leftChild == null)
            {
                if (current == root)
                {
                    root = current.rightChild;
                }
                else if (isLeftChild)
                {
                    parent.leftChild = current.rightChild;
                }
                else
                {
                    parent.rightChild = current.rightChild;
                }
            }
            else
            {
                Node successor = getSuccessor(current);
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.leftChild = successor;
                }
                else
                {
                    parent.rightChild = successor;
                }
                successor.leftChild = current.leftChild;
            }
            return true;
        }
        private Node getSuccessor(Node delNode)
        {
            Node successorParent = delNode;
            Node successor = delNode;
            Node current = delNode.rightChild;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.leftChild;
            }
            if (successor != delNode.rightChild)
            {
                successorParent.leftChild = successor.rightChild;
                successor.rightChild = delNode.rightChild;
            }
            return successor;
        }
        public void traverse(int traverseType)
        {
            switch (traverseType)
            {
                case 1:
                    Console.Write("Preorder traversal: ");

                    preOrder(root);
                    break;
                case 2:
                    Console.Write("Inorder traversal: ");
                    inOrder(root);
                    break;
                case 3:
                    Console.Write("Postorder traversal: ");
                    postOrder(root);
                    break;
            }
            Console.WriteLine();
        }
        private void preOrder(Node localRoot)
        {
            if (localRoot != null)
            {
                Console.Write(localRoot.id + " ");
                preOrder(localRoot.leftChild);
                preOrder(localRoot.rightChild);
            }
        }
        private void inOrder(Node localRoot)
        {
            if (localRoot != null)
            {
                inOrder(localRoot.leftChild);
                Console.Write(localRoot.id + " ");
                inOrder(localRoot.rightChild);
            }
        }
        private void postOrder(Node localRoot)
        {
            if (localRoot != null)
            {
                postOrder(localRoot.leftChild);
                postOrder(localRoot.rightChild);
                Console.Write(localRoot.id + " ");
            }
        }
        public void displayTree()
        {
            Stack globalStack = new Stack();
            globalStack.Push(root);
            int nBlanks = 32;
            bool isRowEmpty = false;
            Console.Write("......................................................");
            while (isRowEmpty == false)
            {
                Stack localStack = new Stack();
                isRowEmpty = true;
                for (int j = 0; j < nBlanks; j++)
                {
                    Console.Write(' ');
                }
                while (globalStack.Count > 0)
                {
                    Node temp = (Node)globalStack.Pop();

                    if (temp != null)
                    {

                        Console.Write(temp.id);
                        localStack.Push(temp.leftChild);
                        localStack.Push(temp.rightChild);
                        if (temp.leftChild != null

                        || temp.rightChild != null)
                        {
                            isRowEmpty = false;
                        }
                    }
                    else
                    {
                        Console.Write("--");
                        localStack.Push(null);
                        localStack.Push(null);
                    }
                    for (int j = 0; j < nBlanks * 2 - 2; j++)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
                nBlanks /= 2;
                while (localStack.Count > 0)
                {
                    globalStack.Push(localStack.Pop());
                }
            }
            Console.Write("......................................................");
        }
    }
}
