﻿using System.Windows.Media;
using StarryEyes.Anomaly.TwitterApi.DataModels;

namespace StarryEyes.Models.Backstages.TwitterEvents
{
    public sealed class UnfollowedEvent : TwitterEventBase
    {
        public UnfollowedEvent(TwitterUser source, TwitterUser target)
            : base(source, target) { }

        public override string Title
        {
            get { return "UNFOLLOWED"; }
        }

        public override string Detail
        {
            get { return Source.ScreenName + " -/-> " + TargetUser.ScreenName; }
        }

        public override Color Background
        {
            get
            {
                return Colors.DimGray;
            }
        }
    }
}
