﻿#pragma checksum "..\..\..\..\Windows\Author\AuthorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86F61DA62D6D0F8A47B2A7ED41442C75D446C36BF7BF680F05BB7BDB584E5054"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Photos_comparator.Windows;
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


namespace Photos_comparator.Windows {
    
    
    /// <summary>
    /// AuthorWindow
    /// </summary>
    public partial class AuthorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBackButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectPhotoButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ImageCheckBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPhotoButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Photos comparator;component/windows/author/authorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
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
            
            #line 29 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
            this.GoBackButton.Click += new System.Windows.RoutedEventHandler(this.GoBackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SelectPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
            this.SelectPhotoButton.Click += new System.Windows.RoutedEventHandler(this.SelectPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImageCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.CategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AddPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Windows\Author\AuthorWindow.xaml"
            this.AddPhotoButton.Click += new System.Windows.RoutedEventHandler(this.AddPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
