public class TimeMap {
    
    Dictionary<string, List<(int, string)>> d = new   Dictionary<string, List<(int, string)>>();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!d.ContainsKey(key)){
            d.Add(key, new List<(int, string)>{(timestamp, value)});
        }
        else{
            d[key].Add((timestamp, value));
        }
    }
    
    public string Get(string key, int timestamp) {
        if(!d.ContainsKey(key)) return string.Empty;
        else{
            var list = d[key];
            int low =0;
            int high = list.Count -1;

            while(low <= high){
                int mid = low + (high -low) /2;

                if(list[mid].Item1 == timestamp){
                    return list[mid].Item2;
                }

                
                if(list[mid].Item1 < timestamp){
                    low = mid +1;
                }
                else{
                    high = mid-1;
                }

            }
                if (high < 0) return string.Empty;

    return list[high].Item2;       

        }
        
    }
}
