﻿#pragma checksum "..\..\AddInstructor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C4CF622CF7C5C8271C3330BCA2F76EDBAC31287BEC54180D94ED2795E8C911B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_phase2;
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


namespace Project_phase2 {
    
    
    /// <summary>
    /// AddInstructor
    /// </summary>
    public partial class AddInstructor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InstructID;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InstructFname;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InstrucLname;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddInstructbtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InstructCourse;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update_Instruct;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddInstructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_Instructor;
        
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
            System.Uri resourceLocater = new System.Uri("/Project-phase2;component/addinstructor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddInstructor.xaml"
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
            this.InstructID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.InstructFname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.InstrucLname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddInstructbtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AddInstructor.xaml"
            this.AddInstructbtn.Click += new System.Windows.RoutedEventHandler(this.AddInstructbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.InstructCourse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.update_Instruct = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AddInstructor.xaml"
            this.update_Instruct.Click += new System.Windows.RoutedEventHandler(this.update_Instruct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.delete_Instructor = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddInstructor.xaml"
            this.delete_Instructor.Click += new System.Windows.RoutedEventHandler(this.delete_Instructor_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
