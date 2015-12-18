﻿#pragma checksum "..\..\Assessment.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4544D6E728EF156016B3D7B243D72C03"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AWrite;
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


namespace AWrite {
    
    
    /// <summary>
    /// Assessment
    /// </summary>
    public partial class Assessment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboAssessmentType;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAssessmentName;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAssessmentCode;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtxtAssessmentScenario;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbCourseUnits;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbUnitsAssessed;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddUnit;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveUnit;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkCourseUnitID;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\Assessment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoSetUpTasks;
        
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
            System.Uri resourceLocater = new System.Uri("/AWrite;component/assessment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Assessment.xaml"
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
            this.cboAssessmentType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.txtAssessmentName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtAssessmentCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rtxtAssessmentScenario = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 5:
            this.lbCourseUnits = ((System.Windows.Controls.ListBox)(target));
            
            #line 137 "..\..\Assessment.xaml"
            this.lbCourseUnits.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbCourseUnits_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbUnitsAssessed = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btnAddUnit = ((System.Windows.Controls.Button)(target));
            
            #line 194 "..\..\Assessment.xaml"
            this.btnAddUnit.Click += new System.Windows.RoutedEventHandler(this.btnAddUnit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRemoveUnit = ((System.Windows.Controls.Button)(target));
            
            #line 201 "..\..\Assessment.xaml"
            this.btnRemoveUnit.Click += new System.Windows.RoutedEventHandler(this.btnRemoveUnit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbkCourseUnitID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.btnGoSetUpTasks = ((System.Windows.Controls.Button)(target));
            
            #line 220 "..\..\Assessment.xaml"
            this.btnGoSetUpTasks.Click += new System.Windows.RoutedEventHandler(this.btnGoSetUpTasks_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
