using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Binary_Search_Tree
{
    class Tree
    {
        Node root; // a Root of Type  Node

   //Constractor
        public  Tree() // Creating an Empty Tree
        {
            root = null;

        }

        public Tree(int Input) // Creating a Tree with an Initial Input 'Root'
        {
            root = new Node(Input);

        }

        public void add(int data) 
        {

            if (root == null) // tree Empty 
            {
                //  Need new Node
                Node newNode = new Node(data);
                root = newNode;
                return;
            }
            // If Input  Is Less or Equall than Current Node we Move Left 
            Node currentNode = root;
            bool added = false;
            do
            {
                if(data <= currentNode.data)//Go Left
                {
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(data);
                        currentNode.left = newNode;
                        added =true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }

                // If Input  Is Greather  than Current Node we Move Right 

                if (data > currentNode.data) //Go Right
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(data);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }

            }
            while (!added);
        }
        public void search() // Search Methode
        {

        }
    }   
}
