﻿
namespace ExchangeLINQ
{
	public static class UrlConstants
	{
		public const string BaseUrl =									"https://api.stackexchange.com/2.0";
		public const string AnswersUrl =								"/answers";	
		public const string AnswersByIdUrl =							"/answers/{0}";
		public const string CommentsByAnswerIdUrl =						"/answers/{0}/comments";
		public const string BadgesUrl =									"/badges";
		public const string BadgesByIdUrl =								"/badges/{0}";
		public const string NonTagBasedBadgesUrl =						"/badges/name";
		public const string BadgesRecipientsUrl =						"/badges/recipients";
		public const string RecipientsByBadgeIdUrl =					"/badges/{0}/recipients";
		public const string TagBasedBadgesUrl =							"/badges/tags";
		public const string CommentsUrl =								"/comments";
		public const string CommentsByIdUrl =							"/comments/{0}";
		public const string EventsUrl =									"/events";
		public const string InfoUrl =									"/info";
		public const string PostsUrl =									"/posts";
		public const string PostsById =									"/posts/{0}";
		public const string CommentsByPostId =							"/posts/{0}/comments";
		public const string RevisionsByPostId =							"/posts/{0}/revisions";
		public const string SuggestedEditsByPostId =					"/posts/{0}/suggested-edits";
		public const string PrivilegesUrl =								"/privileges";
		public const string QuestionsUrl =								"/questions";
		public const string QuestionsByIdUrl =							"/questions/{0}";
		public const string AnswersByQuestionIdUrl =					"/questions/{0}/answers";
		public const string CommentsByQuestionId =						"/questions/{0}/comments";
		public const string LinkedQuestionsByQuestionIdUrl =			"/questions/{0}/linked";
		public const string RelatedQuestionsByQuestionIdUrl =			"/questions/{0}/related";
		public const string TimelineByQuestionId =						"/questions/{0}/timeline";
		public const string FeaturedQuestionsUrl =						"/questions/featured";
		public const string UnansweredQuestionsUrl =					"/questions/unanswered";
		public const string NoAnswersQuestionsUrl =						"/questions/no-answers";
		public const string RevisionsByIdUrl =							"/revisions/{0}";
		public const string SearchUrl =									"/search";
		public const string SimilarUrl =								"/similar";
		public const string SuggestedEditsUrl =							"/suggested-edits";
		public const string SuggestedEditsByIdUrl =						"/suggested-edits/{0}";
		public const string TagsUrl =									"/tags";
		public const string TagsByIdUrl =								"/tags/{tags}/info";
		public const string ModeratorOnlyTagsUrl =						"/tags/moderator-only";
		public const string RequiredTagsUrl =							"/tags/required";
		public const string AllSynonymsTagsUrl =						"/tags/synonyms";
		public const string FaqByTagsUrl =								"/tags/{tags}/faq";
		public const string RelatedTagsUrl =							"/tags/{tags}/related";
		public const string SynonymsTagsUrl =							"/tags/{tags}/synonyms";
		public const string TopAnswerPostersByTagsUrl =					"/tags/{tag}/top-answerers/{period}";
		public const string TopAskerPostersByTagsUrl =					"/tags/{tag}/top-askers/{period}";
		public const string WikiEntriesByTagUrl =						"/tags/{tags}/wikis";
		public const string UsersUrl =									"/users";
		public const string UserssByIdUrl =								"/users/{0}";
		public const string MeUrl =										"/me";
		public const string AnswersByUserIdUrl =						"/users/{0}/answers";
		public const string AnswersByMeUrl =							"/me/answers";
		public const string BadgesByUserIdUrl =							"/users/{0}/badge";
		public const string BadgesByMeUrl =								"/me/badges";
		public const string CommentsByUserIdUrl =						"/users/{0}/comments";
		public const string CommentsByMeUrl =							"/me/comments";
		public const string CommentsToUserIdByUserIdUrl =				"/users/{0}/comments/{toid}";
		public const string CommentsToUserIdByMeUrl =					"/me/comments/{toid}";
		public const string FavoritesByUserIdUrl =						"/users/{0}/favorites";
		public const string FavoritesByMeUrl =							"/me/favorites";
		public const string MentionedByUserIdUrl =						"/users/{0}/mentioned";
		public const string MentionedByMeUrl =							"/me/mentioned";
		public const string PrivilegesByUserIdUrl =						"/users/{0}/privileges";
		public const string PrivilegesByMeUrl =							"/me/privileges";
		public const string QuestionsByUserIdUrl =						"/users/{0}/questions";
		public const string QuestionsByMeUrl =							"/me/questions";
		public const string FeaturedQuestionsByUserIdUrl =				"/users/{0}/questions/featured";
		public const string FeaturedQuestionsByMeUrl =					"/me/questions/featured";
		public const string NoAnswersQuestionsByUserIdUrl =				"/users/{0}/questions/no-answers";
		public const string NoAnswersQuestionsByMeUrl =					"/me/questions/no-answers";
		public const string UnacceptedQuestionsByUserIdUrl =			"/users/{0}/questions/unaccepted";
		public const string UnacceptedQuestionsByMeUrl =				"/me/questions/unaccepted";
		public const string UnansweredQuestionsByUserIdUrl =			"/users/{0}/questions/unanswered";
		public const string UnansweredQuestionsByMeUrl =				"/me/questions/unanswered";
		public const string ReputationByUserIdUrl =						"/users/{0}/reputation";
		public const string ReputationByMeUrl =							"/me/reputation";
		public const string SuggestedEditsByUserIdUrl =					"/users/{0}/suggested-edits";
		public const string SuggestedEditsByMeUrl =						"/me/suggested-edits";
		public const string TagsByUserIdUrl =							"/users/{0}/tags";
		public const string TagsByMeUrl =								"/me/tags";
		public const string TopAnswersByTagByUserIdUrl =				"/users/{0}/tags/{tags}/top-answers";
		public const string TopAnswersByTagByMeUrl =					"/me/tags/{tags}/top-answers";
		public const string TopQuestionByTagByUserIdUrl =				"/users/{0}/tags/{tags}/top-questions";
		public const string TopQuestionByTagByMeUrl =					"/me/tags/{tags}/top-questions";
		public const string TimelineByUserIdUrl =						"/users/{0}/timeline";
		public const string TimelineByMeUrl =							"/me/timeline";
		public const string TopAnswerTagsByUserIdUrl =					"/users/{0}/top-answer-tags";
		public const string TopAnswerTagsByMeUrl =						"/me/top-answer-tags";
		public const string TopQuestionTagsByUserIdUrl =				"/users/{0}/top-question-tags";
		public const string TopQuestionTagsByMeUrl =					"/me/top-question-tags";
		public const string ModeratorsUrl =								"/users/moderators";
		public const string ElectedModeratorsUrl =						"/users/moderators/elected";
		public const string InboxByUserIdUrl =							"/users/{0}/inbox";
		public const string InboxByMeUrl =								"/me/inbox";
		public const string UnreadInboxByUserIdUrl =					"/users/{0}/inbox/unread";
		public const string UnreadInboxByMeUrl =						"/me/inbox/unread";
		public const string InvalidateAccessTokensByNameUrl =			"/access-tokens/{accessTokens}/invalidate";
		public const string AccessTokensByNameUrl =						"/access-tokens/{accessTokens}";
		public const string DeauthenticateAppsByAccessTokensUrl =		"/apps/{accessTokens}/de-authenticate";
		public const string ErrorsUrl =									"/errors";
		public const string ErrorsByIdUrl =								"/errors/{0}";
		public const string CreateFilterUrl =							"/filters/create";
		public const string FiltersByNameUrl =							"/filters/{filters}";
		public const string InboxUrl =									"/inbox";
		public const string InboxUnreadUrl =							"/inbox/unread";
		public const string SitesUrl =									"/sites";
		public const string AssociatedUsersByIdUrl =						"/users/{0}/associated";
		public const string AssociatedMeUrl =							"/me/associated";
	}
}