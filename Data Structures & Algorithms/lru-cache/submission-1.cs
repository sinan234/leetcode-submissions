public class LRUCache {

    int max = 0;
    Dictionary<int,int> d = new Dictionary<int,int>();
    LinkedList<int> l = new LinkedList<int>();
    int size =0;

    public LRUCache(int capacity) {
        max = capacity;
    }
    
    public int Get(int key) {
        if(d.ContainsKey(key)){
            l.Remove(key);
            l.AddFirst(key);

            return d[key];
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(d.ContainsKey(key)){
            d[key] = value;
        }
        else if(size >= max){
           d.Remove(l.Last.Value);
           l.Remove(l.Last);
           size = max;

           d.Add(key,value);
        }
        else{
            d.Add(key, value);
            size ++;
        }

        l.Remove(key);
        l.AddFirst(key);

    }
}
