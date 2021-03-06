﻿using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AssociatedUsers
{
	public class AssociatedUsersFilteredByUserId : ProcessorState<NetworkUser>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssociatedUsersFilteredByUserId"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal AssociatedUsersFilteredByUserId(ExchangeUrl url, FilterUserIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.AssociatedUsersByIdUrl, ids.Value);
		}

		public FilteredByPage<AccessToken> Where(Func<IPage, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
