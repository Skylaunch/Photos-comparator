﻿#pragma checksum "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A39BA3E9A25D69EF4A5663B2D60B0C8003602E10267B39C25A3206393CB5B79A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Photos_comparator.Windows.User;
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


namespace Photos_comparator.Windows.User {
    
    
    /// <summary>
    /// SearchInDatabaseWindow
    /// </summary>
    public partial class SearchInDatabaseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBackButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectPhotoButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ImageTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchPhotoButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Photos comparator;component/windows/user/searchindatabasewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
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
            this.GoBackButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
            this.GoBackButton.Click += new System.Windows.RoutedEventHandler(this.GoBackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelectPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
            this.SelectPhotoButton.Click += new System.Windows.RoutedEventHandler(this.SelectPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ImageTextBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.CategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.SearchPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Windows\User\SearchInDatabaseWindow.xaml"
            this.SearchPhotoButton.Click += new System.Windows.RoutedEventHandler(this.SearchPhotoButton_ClickAsync);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

