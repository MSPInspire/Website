using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public class InMemorySearchProvider
    {
        readonly IDictionary<string, Video> videos;
        IDictionary<string, ICollection<(string VideoId, int Count)>> searchIndex;

        public InMemorySearchProvider(IDictionary<string, Video> videos)
        {
            this.videos = videos;
            BuildSearchIndex();
        }

        void BuildSearchIndex()
        {
            searchIndex = new Dictionary<string, ICollection<(string, int)>>();
            foreach (var video in videos.Values)
            {
                var terms = video.Name.ToLower().Split()
                    .GroupBy(term => term)
                    .Select<IGrouping<string, string>, (string Term, int TermCount)>(termGroup => (termGroup.Key, termGroup.Count()));
                foreach (var term in terms)
                {
                    if (!searchIndex.ContainsKey(term.Term))
                    {
                        searchIndex[term.Term] = new List<(string, int)>();
                    }
                    searchIndex[term.Term].Add((video.Id, term.TermCount));
                }
            }
        }

        public IEnumerable<Video> Search(string query)
        {
            return query.ToLower().Split()
                .Where(term => !string.IsNullOrWhiteSpace(term))
                .SelectMany(term => searchIndex.Keys
                    .Where(key => key.StartsWith(term))
                    .SelectMany(key => searchIndex[key]))
                .GroupBy(termCount => termCount.VideoId, termCount => termCount.Count)
                .OrderByDescending(termCounts => termCounts.Sum())
                .Select(termCounts => videos[termCounts.Key]);
        }
    }
}
