﻿using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Questions
{	
	public interface IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter : IPageFromDateFilter
	{
		InProp<FilterIds, int> Id { get; }

		InProp<FilterTags, string> Tags { get; }

		InProp<FilterIsRelatedTo, int> IsRelatedTo { get; }

		IdProp<Equal<FilterLinksToId, int>> LinksTo { get; }

		IdProp<Equal<FilterPostingUserId, int>> PostingUser { get; }

		FilterFeatured IsFeatured { get; }

		FilterUnanswered IsUnanswered { get; }

		FilterNoAnswers HasNoAnswers { get; }
	}

	public interface IQuestionTagsPageFromDateFilter : IPageFromDateFilter
	{
		InProp<FilterTags, string> Tags { get; }
	}

	public interface IOrderByActivityCreationScoreHotWeekMonth : IOrderByActivityCreationScore
	{
		FilterOrderBy Hot { get; }
		FilterOrderBy Week { get; }
		FilterOrderBy Month { get; }
	}

	public interface IOrderByActivityCreationScoreRank : IOrderByActivityCreationScore
	{
		FilterOrderBy Rank { get; }
	}	
}