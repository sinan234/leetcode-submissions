public class PrefixTree {
    private class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public bool isEnd = false;
    }
    
    private TrieNode root;

    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;

        foreach(char c in word){
            int index = c-'a';
            if(curr.children[index] == null){
                curr.children[index] = new TrieNode();
            }
            curr = curr.children[index];
        }
        curr.isEnd = true;
    }
    
 public bool Search(string word) {
        TrieNode curr = root;

        foreach (char c in word) {
            int index = c - 'a';
            if (curr.children[index] == null) {
                return false;
            }
            curr = curr.children[index];
        }

        return curr.isEnd;
    }
    
    public bool StartsWith(string prefix) {
         TrieNode curr = root;

        foreach (char c in prefix) {
            int index = c - 'a';
            if (curr.children[index] == null) {
                return false;
            }
            curr = curr.children[index];
        }

        return true;
    }
}
