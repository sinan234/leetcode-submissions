public class Twitter
{
    Dictionary<int, List<(int tweetId, int timestamp)>> userTweets =
        new Dictionary<int, List<(int tweetId, int timestamp)>>();

    Dictionary<int, HashSet<int>> followingLists =
        new Dictionary<int, HashSet<int>>();

    int time = 1;

    public Twitter()
    {
    }

    public void PostTweet(int userId, int tweetId)
    {
        if (!userTweets.ContainsKey(userId))
        {
            userTweets[userId] = new List<(int tweetId, int timestamp)>();
        }

        userTweets[userId].Add((tweetId, time));
        time++;
    }

    public List<int> GetNewsFeed(int userId)
    {
        List<int> res = new List<int>();

        // Current user + followees
        HashSet<int> users = new HashSet<int> { userId };

        if (followingLists.ContainsKey(userId))
        {
            foreach (int followee in followingLists[userId])
            {
                users.Add(followee);
            }
        }

        // Local Max Heap
        PriorityQueue<(int userId, int index), int> p =
            new PriorityQueue<(int userId, int index), int>(
                Comparer<int>.Create((a, b) => b.CompareTo(a))
            );

        // Insert the latest tweet from each user
        foreach (int user in users)
        {
            if (userTweets.TryGetValue(user, out var tweets) &&
                tweets.Count > 0)
            {
                int index = tweets.Count - 1;

                p.Enqueue(
                    (user, index),
                    tweets[index].timestamp
                );
            }
        }

        // Retrieve the 10 most recent tweets
        while (p.Count > 0 && res.Count < 10)
        {
            var current = p.Dequeue();

            int user = current.userId;
            int index = current.index;

            res.Add(userTweets[user][index].tweetId);

            // Insert the previous tweet from the same user
            int previousIndex = index - 1;

            if (previousIndex >= 0)
            {
                p.Enqueue(
                    (user, previousIndex),
                    userTweets[user][previousIndex].timestamp
                );
            }
        }

        return res;
    }

    public void Follow(int followerId, int followeeId)
    {
        if (followerId == followeeId)
            return;

        if (!followingLists.ContainsKey(followerId))
        {
            followingLists[followerId] = new HashSet<int>();
        }

        followingLists[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (followingLists.ContainsKey(followerId))
        {
            followingLists[followerId].Remove(followeeId);
        }
    }
}