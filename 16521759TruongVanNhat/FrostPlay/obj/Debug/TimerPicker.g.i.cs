﻿#pragma checksum "..\..\TimerPicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C1D937258AD771B4A5878F03B4462CED86132A79C73C1601CBB75577A9B25E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FrostPlay;
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


namespace FrostPlay {
    
    
    /// <summary>
    /// TimerPicker
    /// </summary>
    public partial class TimerPicker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForwardBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderPosition;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label artistAndTitleLabel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label albumLabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\TimerPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image coverImage;
        
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
            System.Uri resourceLocater = new System.Uri("/FrostPlay;component/timerpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TimerPicker.xaml"
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
            this.playBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\TimerPicker.xaml"
            this.playBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stopBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\TimerPicker.xaml"
            this.stopBtn.Click += new System.Windows.RoutedEventHandler(this.stopBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\TimerPicker.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ForwardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\TimerPicker.xaml"
            this.ForwardBtn.Click += new System.Windows.RoutedEventHandler(this.ForwardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 32 "..\..\TimerPicker.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.volumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sliderPosition = ((System.Windows.Controls.Slider)(target));
            
            #line 34 "..\..\TimerPicker.xaml"
            this.sliderPosition.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.sliderPosition_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\TimerPicker.xaml"
            this.sliderPosition.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.sliderPosition_PreviewMouseUp);
            
            #line default
            #line hidden
            
            #line 34 "..\..\TimerPicker.xaml"
            this.sliderPosition.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderPosition_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.timeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.artistAndTitleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.albumLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.coverImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

