﻿using Lab_4.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Lab_4.Command;
using Lab_4.Model;

namespace Lab_4.VM
{
    public class StartVM : VM1
    {
        private int count;
        private int right;
        private bool isMainWindowOpen = false;
        private ICommand openMainWindowCommand;

        public int Count { get { return count; } set { count = value; } }
        public int Right { get { return right; } set { right = value; } }
        public ICommand OpenMainWindowCommand
        {
            get
            {
                if (openMainWindowCommand == null)
                {
                    openMainWindowCommand = new Relay(OpenMainWindow);
                }
                return openMainWindowCommand;
            }
        }
        private void OpenMainWindow()
        {
            if (!isMainWindowOpen)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                //mainWindow.Closed += (sender, e) => { isMainWindowOpen = false; };
                mainWindow.Show();

                isMainWindowOpen = true;
            }
        }
        public StartVM()
        {
            Count = new int();
            Right = new int();
        }       
    }
}
