// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4Mvc;
namespace Magenic.BadgeApplication.Controllers
{
    public partial class LeaderboardController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LeaderboardController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected LeaderboardController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Search()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Show()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Show);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Compare()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Compare);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Delete()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LeaderboardController Actions { get { return Mvc.Leaderboard; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Leaderboard";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Leaderboard";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Rank = "Rank";
            public readonly string Search = "Search";
            public readonly string Show = "Show";
            public readonly string Compare = "Compare";
            public readonly string Delete = "Delete";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Rank = "Rank";
            public const string Search = "Search";
            public const string Show = "Show";
            public const string Compare = "Compare";
            public const string Delete = "Delete";
        }


        static readonly ActionParamsClass_Search s_params_Search = new ActionParamsClass_Search();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Search SearchParams { get { return s_params_Search; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Search
        {
            public readonly string searchText = "searchText";
        }
        static readonly ActionParamsClass_Show s_params_Show = new ActionParamsClass_Show();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Show ShowParams { get { return s_params_Show; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Show
        {
            public readonly string userName = "userName";
        }
        static readonly ActionParamsClass_Compare s_params_Compare = new ActionParamsClass_Compare();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Compare CompareParams { get { return s_params_Compare; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Compare
        {
            public readonly string userName = "userName";
        }
        static readonly ActionParamsClass_Delete s_params_Delete = new ActionParamsClass_Delete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Delete DeleteParams { get { return s_params_Delete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Delete
        {
            public readonly string badgeAwardId = "badgeAwardId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _EarnedBadgeList = "_EarnedBadgeList";
                public readonly string _EarnedBadgeWindow = "_EarnedBadgeWindow";
                public readonly string Compare = "Compare";
                public readonly string Index = "Index";
                public readonly string Rank = "Rank";
                public readonly string Search = "Search";
                public readonly string Show = "Show";
            }
            public readonly string _EarnedBadgeList = "~/Views/Leaderboard/_EarnedBadgeList.cshtml";
            public readonly string _EarnedBadgeWindow = "~/Views/Leaderboard/_EarnedBadgeWindow.cshtml";
            public readonly string Compare = "~/Views/Leaderboard/Compare.cshtml";
            public readonly string Index = "~/Views/Leaderboard/Index.cshtml";
            public readonly string Rank = "~/Views/Leaderboard/Rank.cshtml";
            public readonly string Search = "~/Views/Leaderboard/Search.cshtml";
            public readonly string Show = "~/Views/Leaderboard/Show.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_LeaderboardController : Magenic.BadgeApplication.Controllers.LeaderboardController
    {
        public T4MVC_LeaderboardController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void RankOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Rank()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Rank);
            RankOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void SearchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string searchText);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Search(string searchText)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "searchText", searchText);
            SearchOverride(callInfo, searchText);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ShowOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string userName);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Show(string userName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Show);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userName", userName);
            ShowOverride(callInfo, userName);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void CompareOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string userName);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Compare(string userName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Compare);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userName", userName);
            CompareOverride(callInfo, userName);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int badgeAwardId);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Delete(int badgeAwardId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "badgeAwardId", badgeAwardId);
            DeleteOverride(callInfo, badgeAwardId);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
