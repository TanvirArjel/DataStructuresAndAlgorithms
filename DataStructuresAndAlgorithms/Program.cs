﻿// <copyright file="Program.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using DataStructuresAndAlgorithms.DataStructures.Trees;

namespace DataStructuresAndAlgorithms
{
    internal static class Program
    {
        private static void Main()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            BinaryTreeNode<int> root = null;
            root = binarySearchTree.InsertRecursive(root, 1);
            root = binarySearchTree.InsertRecursive(root, 2);
            root = binarySearchTree.InsertRecursive(root, 3);
            root = binarySearchTree.InsertRecursive(root, 4);
            root = binarySearchTree.InsertRecursive(root, 5);
            root = binarySearchTree.InsertRecursive(root, 6);
            root = binarySearchTree.InsertRecursive(root, 7);

            Console.WriteLine("");
        }

        private static int Method2()
        {
            int[] intArray = new int[] { 3, 8, 2, 3, 3, 2 };

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            for (int i = 0; i < intArray.Length; i++)
            {
                int currentNumber = intArray[i];
                int currentNumberCount;

                if (numberCounts.TryGetValue(currentNumber, out currentNumberCount))
                {
                    numberCounts[currentNumber] = currentNumberCount + 1;
                }
                else
                {
                    numberCounts[currentNumber] = 1;
                }
            }

            int[] validNumbers = numberCounts.Where(num => num.Key == num.Value).Select(num => num.Key).ToArray();

            int maxNumber = 0;

            for (int i = 0; i < validNumbers.Length; i++)
            {
                if (validNumbers[i] > maxNumber)
                {
                    maxNumber = validNumbers[i];
                }
            }

            Console.WriteLine(maxNumber);

            return maxNumber;
        }

        private static int Method1()
        {
            string inputString = "We test coders. Give us a try?";

            char[] delimiters = new char[] { '.', '?', '!' };

            string[] sentences = inputString.Split(delimiters);

            int longestSentenceLength = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                string currentSentence = sentences[i];
                string[] currentSentenceWords = currentSentence.Split(' ');

                currentSentenceWords = currentSentenceWords.Where(csw => !string.IsNullOrEmpty(csw)).ToArray();
                if (currentSentenceWords.Length > longestSentenceLength)
                {
                    longestSentenceLength = currentSentenceWords.Length;
                }
            }

            return longestSentenceLength;
        }
    }
}
