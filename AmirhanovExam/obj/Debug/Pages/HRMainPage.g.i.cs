﻿#pragma checksum "..\..\..\Pages\HRMainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52A42E2650DADAF2D43E23566F001505DB7DE045117A84F6545FC4B7BF767B7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AmirhanovExam.Pages;
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


namespace AmirhanovExam.Pages {
    
    
    /// <summary>
    /// HRMainPage
    /// </summary>
    public partial class HRMainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBRole;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGEmployee;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAdd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRed;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image QRCodeImage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\HRMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BShowQR;
        
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
            System.Uri resourceLocater = new System.Uri("/AmirhanovExam;component/pages/hrmainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\HRMainPage.xaml"
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
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Pages\HRMainPage.xaml"
            this.TBName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBRole = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Pages\HRMainPage.xaml"
            this.CBRole.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBRole_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DGEmployee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.BAdd = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\HRMainPage.xaml"
            this.BAdd.Click += new System.Windows.RoutedEventHandler(this.BAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BRed = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\HRMainPage.xaml"
            this.BRed.Click += new System.Windows.RoutedEventHandler(this.BRed_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BDel = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\HRMainPage.xaml"
            this.BDel.Click += new System.Windows.RoutedEventHandler(this.BDel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.QRCodeImage = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.BShowQR = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\HRMainPage.xaml"
            this.BShowQR.Click += new System.Windows.RoutedEventHandler(this.BShowQR_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

