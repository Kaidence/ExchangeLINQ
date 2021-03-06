﻿using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	public class BadgesFilteredByIdRecent : ProcessorState<Badge>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BadgesFilteredByIdRecent"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal BadgesFilteredByIdRecent(ExchangeUrl url, FilterIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.RecipientsByBadgeIdUrl, string.Join(";", ids.Value));
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
	}
}
