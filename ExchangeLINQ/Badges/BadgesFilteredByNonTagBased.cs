﻿using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	public class BadgesFilteredByNonTagBased : ProcessorState<Badge>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BadgesFilteredById"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal BadgesFilteredByNonTagBased(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.NonTagBasedBadgesUrl;
		}

		#region Complex

		public FilteredByPage<Answer> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new BadgesInterfacesImpl());
			return new FilteredByPage<Answer>(this.Url, filter);
		}

		public FilteredByFromDate<Answer> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new BadgesInterfacesImpl());
			return new FilteredByFromDate<Answer>(this.Url, filter);
		}

		public FilteredByFilter<Answer> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new BadgesInterfacesImpl());
			return new FilteredByFilter<Answer>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<Answer> OrderBy(Func<IBadgesOrderByNameRank, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new BadgesInterfacesImpl());
			return new OrderBy<Answer>(this.Url, filter);
		}

		public OrderByDescending<Answer> OrderByDescending(Func<IBadgesOrderByNameRank, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new BadgesInterfacesImpl());
			return new OrderByDescending<Answer>(this.Url, filter);
		}

		#endregion
	}
}
