﻿using System;

// SpamFindWords.cs created with MonoDevelop
// User: cmack at 10:36 AM 5/30/2009
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

namespace cfm.NaiveBayes
{
    public class SpamFindWords : FindWords
    {
		
		public SpamFindWords()
		{
		}
		
		public override string GetArticleQuery()
        {
            return @"
				SELECT 	Body
				FROM	Spam;		
			";
		}
		
		protected override string[] SplitWords(string article)
        {
            return article.Split(' ');
        }
	}
}
