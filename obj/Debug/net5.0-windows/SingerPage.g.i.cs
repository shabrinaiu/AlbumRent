#pragma checksum "..\..\..\SingerPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7C00A5361FE157B4B9A168B2262C018AF401B05F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DatabaseConnection_EntityFramework;
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


namespace DatabaseConnection_EntityFramework {
    
    
    /// <summary>
    /// AlbumPage
    /// </summary>
    public partial class AlbumPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AlbumIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AlbumNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AlbumBandTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AlbumDataGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateSinger;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateSinger;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteSinger;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\SingerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DatabaseConnection_EntityFramework;V1.0.0.0;component/singerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SingerPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AlbumIdTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\SingerPage.xaml"
            this.AlbumIdTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AlbumIdTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AlbumNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\SingerPage.xaml"
            this.AlbumNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AlbumTitleTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AlbumBandTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\SingerPage.xaml"
            this.AlbumBandTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AlbumBandTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AlbumDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.CreateSinger = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\SingerPage.xaml"
            this.CreateSinger.Click += new System.Windows.RoutedEventHandler(this.CreateSinger_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateSinger = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\SingerPage.xaml"
            this.UpdateSinger.Click += new System.Windows.RoutedEventHandler(this.UpdateSinger_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteSinger = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\SingerPage.xaml"
            this.DeleteSinger.Click += new System.Windows.RoutedEventHandler(this.DeleteSinger_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\SingerPage.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

