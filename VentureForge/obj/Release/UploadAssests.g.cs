﻿#pragma checksum "..\..\UploadAssests.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B8C256FF878A7F62B554818D5542228F00EF07ED63680C6B50DA76130DAD21DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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
using VentureForge;


namespace VentureForge {
    
    
    /// <summary>
    /// UploadAssests
    /// </summary>
    public partial class UploadAssests : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\UploadAssests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UploadAssests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadFile;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UploadAssests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UploadAssests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignIn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UploadAssests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTable;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\UploadAssests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox myTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/VentureForge;component/uploadassests.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UploadAssests.xaml"
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
            this.Home = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\UploadAssests.xaml"
            this.Home.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UploadFile = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\UploadAssests.xaml"
            this.UploadFile.Click += new System.Windows.RoutedEventHandler(this.UploadFile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Login = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\UploadAssests.xaml"
            this.Login.Click += new System.Windows.RoutedEventHandler(this.Login_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SignIn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\UploadAssests.xaml"
            this.SignIn.Click += new System.Windows.RoutedEventHandler(this.SignIn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreateTable = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\UploadAssests.xaml"
            this.CreateTable.Click += new System.Windows.RoutedEventHandler(this.CreateTable_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.myTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

