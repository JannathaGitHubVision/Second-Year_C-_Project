﻿#pragma checksum "..\..\DisplayAcademics!.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA876A44962E210B3224C61F6ABC8560D9EB708E79FD210FFA777A4EE9897A94"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SampleProgPoe;
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


namespace SampleProgPoe {
    
    
    /// <summary>
    /// DisplayAcademics_
    /// </summary>
    public partial class DisplayAcademics_ : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\DisplayAcademics!.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox displayTextbox;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\DisplayAcademics!.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaptureValuesText;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\DisplayAcademics!.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridViewData;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\DisplayAcademics!.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ModuleDatePicker;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\DisplayAcademics!.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ModuleComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SampleProgPoe;component/displayacademics!.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DisplayAcademics!.xaml"
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
            
            #line 12 "..\..\DisplayAcademics!.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToMenu);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\DisplayAcademics!.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToCapture);
            
            #line default
            #line hidden
            return;
            case 3:
            this.displayTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CaptureValuesText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 98 "..\..\DisplayAcademics!.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SubmitButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridViewData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.ModuleDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 101 "..\..\DisplayAcademics!.xaml"
            this.ModuleDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.ModuleDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ModuleComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 103 "..\..\DisplayAcademics!.xaml"
            this.ModuleComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ModuleComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
