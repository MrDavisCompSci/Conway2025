namespace GameOfLife;

static class PatternCollection
{
    static private Dictionary<string, List<(int,int)>> patterns = new Dictionary<string,List<(int,int)>>
        {
            {"glider", new List<(int, int)> {
                (15,9),(15, 10),(15,11),(14,11),(13,10)
                }
            },
            {"gosper", new List<(int,int)> {
                (1,5),(2,5),(1,6),(2,6),(11,5),(11,6),
                (11,7),(12,4),(13,3),(14,3),(12,8),(13,9),
                (14,9),(15,6),(16,4),(17,5),(17,6),(17,7),
                (18,6),(16,8),(21,3),(21,4),(21,5),(22,3),
                (22,4),(22,5),(23,2),(23,6),(25,1),(25,2),
                (25,6),(25,7),(35,3),(35,4),(36,3),(36,4)
                }
            }
        
        };

    static public List<(int,int)> GetPattern(string patternName)
    {
        return patterns[patternName];
    }

}