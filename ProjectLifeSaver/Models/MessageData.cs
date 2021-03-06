﻿using NotifyPropertyChangedBase;
using System;

namespace ProjectLifeSaver.Models
{
    public sealed class MessageData : NotifyPropertyChanged
    {
        public static string SENDER_ME = "Me";
        public static string SENDER_ASSISTANT = "Assistant";

        public string Message
        {
            get { return (string)GetValue(); }
            set { SetValue(value); }
        }
        public string Sender
        {
            get { return (string)GetValue(); }
            set { SetValue(value); }
        }
        public DateTime Received
        {
            get { return (DateTime)GetValue(); }
            set { SetValue(value); }
        }

        public MessageData()
        {
            RegisterProperty(nameof(Message), typeof(string), null);
            RegisterProperty(nameof(Sender), typeof(string), null);
            RegisterProperty(nameof(Received), typeof(DateTime), new DateTime());
        }
    }
}
