﻿#pragma checksum "..\..\CreateModule.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6042209D71C35903154BD91A7CA12AE5F34BDEDCAD43F8B556FC53E3BA024D8"
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
    /// CreateModule
    /// </summary>
    public partial class CreateModule : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 144 "..\..\CreateModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBox;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\CreateModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ShowName;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\CreateModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CreatedAssets;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\CreateModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UploadedAssets;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\CreateModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CreatedSheets;
        
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
            System.Uri resourceLocater = new System.Uri("/VentureForge;component/createmodule.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateModule.xaml"
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
            
            #line 32 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadAssests_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExamineAssets_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 58 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateSheets_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 70 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExamineSheets_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 82 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadModule_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 94 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 105 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SginIn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 116 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Login_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 128 "..\..\CreateModule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.nameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 154 "..\..\CreateModule.xaml"
            this.nameBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ModName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ShowName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.CreatedAssets = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.UploadedAssets = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.CreatedSheets = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
