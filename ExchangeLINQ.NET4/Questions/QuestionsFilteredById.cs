﻿using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredById : ProcessorState<Question>
	{
		private FilterIds ids;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal QuestionsFilteredById(ExchangeUrl url, FilterIds ids)
		{
			if(url == null)
			{
				throw new ArgumentNullException("url");
			}
			if(ids == null)
			{
				throw new ArgumentNullException("ids");
			}
			this.Url = url;
			this.ids = ids;
			this.Url.QueryUrl = string.Format(UrlConstants.QuestionsByIdUrl, String.Join(";", ids.Value));
		}

		public FilteredByPage<Question> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new InterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<Question>(this.Url, filter);
		}

		public QuestionsOrderBy OrderBy(Func<IQuestionsOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new QuestionsOrderBy(this.Url, filter);
		}

		public QuestionsOrderByDescending OrderByDescending(Func<IQuestionsOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new QuestionsOrderByDescending(this.Url, filter);
		}
	}
}
