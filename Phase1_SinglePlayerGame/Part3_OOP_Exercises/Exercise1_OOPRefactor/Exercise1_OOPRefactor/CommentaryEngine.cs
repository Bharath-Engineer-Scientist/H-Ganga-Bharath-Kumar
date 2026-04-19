using System;
using System.Collections.Generic;
namespace Exercise1_OOPRefactor
{
    public static class CommentaryEngine
    {
        private static Random _random = new Random();
        private static List<string> dotLines = new List<string> {
            "Dot ball. The bowler wins this battle.",
            "Played and missed! Beat him for pace.",
            "Straight to the fielder. No run.",
            "Solid defense. No room for a shot.",
            "A tight delivery. Pressure is building."
        };
        private static List<string> fourLines = new List<string> {
            "FOUR! That's a classic cover drive!",
            "Cracked away through the gap for four!",
            "The fielder chases, but the ball wins! Boundary!",
            "Timed to perfection! The ball races to the rope.",
            "Beautiful shot! That's four more to the total."
        };
        private static List<string> sixLines = new List<string> {
            "SIX! That is massive! Into the top tier!",
            "Out of the park! High, long, and gone!",
            "Maximum! A monstrous hit from the batsman!",
            "Clean as a whistle! That's a huge six!",
            "Incredible power! Over the ropes for six!"
        };
        private static List<string> outLines = new List<string> {
            "OUT! The stumps are a mess!",
            "GONE! A brilliant catch in the deep!",
            "BOWLED HIM! A perfect yorker!",
            "In the air... and taken! The innings ends.",
            "He's played all over that one. Big wicket!"
        };
        private static List<string> otherLines = new List<string> {
            "Good running. They pick up a couple.",
            "Nudged away into the gap for runs.",
            "Just a single, keeps the scoreboard ticking.",
            "Controlled shot, easy runs there.",
            "Quick feet and they scamper back for two."
        };
        public static string GetCommentary(BallResult result, int runs)
        {
            List<string> pool;
            if (result == BallResult.Out) pool = outLines;
            else if (runs == 6) pool = sixLines;
            else if (runs == 4) pool = fourLines;
            else if (result == BallResult.Dot) pool = dotLines;
            else pool = otherLines;
            return pool[_random.Next(pool.Count)];
        }
    }
}