﻿using System.Windows;
using OfficeRibbonXEditor.Interfaces;

namespace OfficeRibbonXEditor.Services
{
    public class MessageBoxService : IMessageBoxService
    {
        public MessageBoxResult Show(string text, string caption, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.None)
        {
            return MessageBox.Show(text, caption, button, image);
        }
    }
}
