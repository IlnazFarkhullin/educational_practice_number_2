﻿#pragma checksum "..\..\..\Pages\War_number_two.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44FF2535C1DBEC00EE545038D7DB7C12C513844216BAE2D65612379044D4B23E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Childrens_sanatorium.Pages;
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


namespace Childrens_sanatorium.Pages {
    
    
    /// <summary>
    /// War_number_two
    /// </summary>
    public partial class War_number_two : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid panelHeader;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serach_tb;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sort_az;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filter;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock count;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\War_number_two.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView children;
        
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
            System.Uri resourceLocater = new System.Uri("/Childrens_sanatorium;component/pages/war_number_two.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\War_number_two.xaml"
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
            this.panelHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.serach_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Pages\War_number_two.xaml"
            this.serach_tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.serach_tb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\War_number_two.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sort_az = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\War_number_two.xaml"
            this.sort_az.Click += new System.Windows.RoutedEventHandler(this.sort_az_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.filter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Pages\War_number_two.xaml"
            this.filter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.count = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.children = ((System.Windows.Controls.ListView)(target));
            
            #line 44 "..\..\..\Pages\War_number_two.xaml"
            this.children.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.children_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

