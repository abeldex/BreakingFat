﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494A3CC834F442346A87AE642076779188E0C1A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using SistemaGym;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SistemaGym {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MenuListBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton MenuToggleButton;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_titulo;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush wallpaper;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Snackbar MainSnackbar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SistemaGym;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.logo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.MenuListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_MouseLeftButtonUp_2);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 53 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_MouseLeftButtonUp_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_MouseLeftButtonUp_3);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 65 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_MouseLeftButtonUp_4);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MenuToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 9:
            
            #line 85 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txt_titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.wallpaper = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 12:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 13:
            this.MainSnackbar = ((MaterialDesignThemes.Wpf.Snackbar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

