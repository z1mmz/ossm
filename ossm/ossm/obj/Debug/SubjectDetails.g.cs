﻿#pragma checksum "..\..\SubjectDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E2B96EE7E2F7330E894B80FDAEECC6F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace ossm {
    
    
    /// <summary>
    /// SubjectDetails
    /// </summary>
    public partial class SubjectDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\SubjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock subjectDescBlock;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SubjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SubjectCodeBlock;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\SubjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock subjectNameBlock;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SubjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox assListBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\SubjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FileListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ossm;component/subjectdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SubjectDetails.xaml"
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
            this.subjectDescBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.SubjectCodeBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.subjectNameBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.assListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.FileListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 15 "..\..\SubjectDetails.xaml"
            this.FileListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FileListBoxSelect);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

