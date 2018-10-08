using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    class TrieNode
    {

        // R links to node children
        private TrieNode[] links;

        private const int R = 26;

        private bool isEnd;
        private int Size = 0;

        public TrieNode()
        {
            links = new TrieNode[R];
        }

        public bool containsKey(char ch)
        {
            return links[ch - 'a'] != null;
        }
        public TrieNode get(char ch)
        {
            return links[ch - 'a'];
        }
        
        public void setEnd()
        {
            isEnd = true;
        }
        public bool IsEnd()
        {
            return isEnd;
        }
        public void Put(char ch, TrieNode node)
        {
            links[ch - 'a'] = node;
            Size++;
        }

        public int getLinks()
        {
            return Size;
        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void Insert(string word)
        {
            TrieNode node = root;
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];
                if (!node.containsKey(currentChar))
                {
                    node.Put(currentChar, new TrieNode());
                    var y = node.getLinks();
                }
                node = node.get(currentChar);
            }
            node.setEnd();
        }


        //assume methods insert, search, searchPrefix are implemented as it is described
        //in  https://leetcode.com/articles/implement-trie-prefix-tree/)
        public string SearchLongestPrefix(string word)
        {
            TrieNode node = root;
            StringBuilder prefix = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                char curLetter = word[i];
                int x = node.getLinks();
                if (node.containsKey(curLetter) && (node.getLinks() == 1) && (!node.IsEnd()))
                {
                    prefix.Append(curLetter);
                    node = node.get(curLetter);
                }
                else
                    return prefix.ToString();

            }
            return prefix.ToString();
        }

        
    }
    class LongestCommonPrefix
    {
       public string longestCommonPrefix(string q, string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];
            Trie trie = new Trie();
            for (int i = 0; i < strs.Length; i++)
            {
                trie.Insert(strs[i]);
            }
            return trie.SearchLongestPrefix(q);
        }
        public void find()
        {
            Console.WriteLine("testing");
        }
    }
}
