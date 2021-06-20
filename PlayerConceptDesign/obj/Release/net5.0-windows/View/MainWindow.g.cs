﻿#pragma checksum "..\..\..\..\View\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D27CAF8FD498E98AEADB3ED026DBC77B75E0C6D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PlayerConceptDesign;
using PlayerConceptDesign.ViewModel;
using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PlayerConceptDesign.View {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MenuPanel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ButtonAdv MenuHome;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ButtonAdv MenuLibrary;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ButtonAdv MenuPlayList;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ButtonAdv MenuLikes;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ButtonAdv MenuSettings;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border InfoBorder;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PlayerConceptDesign;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MenuPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.MenuHome = ((Syncfusion.Windows.Tools.Controls.ButtonAdv)(target));
            
            #line 41 "..\..\..\..\View\MainWindow.xaml"
            this.MenuHome.Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\View\MainWindow.xaml"
            this.MenuHome.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\View\MainWindow.xaml"
            this.MenuHome.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MenuLibrary = ((Syncfusion.Windows.Tools.Controls.ButtonAdv)(target));
            
            #line 43 "..\..\..\..\View\MainWindow.xaml"
            this.MenuLibrary.Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\View\MainWindow.xaml"
            this.MenuLibrary.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\View\MainWindow.xaml"
            this.MenuLibrary.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenuPlayList = ((Syncfusion.Windows.Tools.Controls.ButtonAdv)(target));
            
            #line 45 "..\..\..\..\View\MainWindow.xaml"
            this.MenuPlayList.Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\..\View\MainWindow.xaml"
            this.MenuPlayList.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\..\View\MainWindow.xaml"
            this.MenuPlayList.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuLikes = ((Syncfusion.Windows.Tools.Controls.ButtonAdv)(target));
            
            #line 47 "..\..\..\..\View\MainWindow.xaml"
            this.MenuLikes.Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\..\View\MainWindow.xaml"
            this.MenuLikes.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\..\View\MainWindow.xaml"
            this.MenuLikes.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MenuSettings = ((Syncfusion.Windows.Tools.Controls.ButtonAdv)(target));
            
            #line 49 "..\..\..\..\View\MainWindow.xaml"
            this.MenuSettings.Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\View\MainWindow.xaml"
            this.MenuSettings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\View\MainWindow.xaml"
            this.MenuSettings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.InfoBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

