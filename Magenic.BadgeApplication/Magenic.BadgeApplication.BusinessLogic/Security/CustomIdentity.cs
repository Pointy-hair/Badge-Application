﻿using System;
using Autofac;
using Csla.Core;
using Csla.Security;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magenic.BadgeApplication.Common.Interfaces;
using Magenic.BadgeApplication.BusinessLogic.Framework;

namespace Magenic.BadgeApplication.BusinessLogic.Security
{
    [Serializable]
    public sealed class CustomIdentity : CslaIdentity
    {
        #region Criteria

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [Serializable]
        public class IdentityCriteria : IIdentityCriteria
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        #endregion Criteria

        #region Methods

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal void Load(string name, IEnumerable<string> roles)
        {
            this.Name = name;
            this.Roles = new MobileList<string>();
            this.Roles.AddRange(roles);
        }

        #endregion Methods

        #region Data Portal

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private async Task DataPortal_Fetch(IdentityCriteria criteria)
        {
            var dal = IoC.Container.Resolve<ICustomIdentityDAL>();

            var result = await dal.LogOnIdentityAsync(criteria.UserName, criteria.Password);
            this.Load(result.Name, result.Roles);
        }

        #endregion  Data Portal

    }
}
