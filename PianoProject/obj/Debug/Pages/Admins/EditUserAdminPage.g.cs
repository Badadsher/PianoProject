﻿#pragma checksum "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11D8C53ED8E43679AA14C8C8BDBB9605D8C0BA82FF87EA1A560E35C290138FC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PianoProject.Pages.Admins;
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


namespace PianoProject.Pages.Admins {
    
    
    /// <summary>
    /// EditUserAdminPage
    /// </summary>
    public partial class EditUserAdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 193 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailbox;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phonebox;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginbox;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passbox;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idrolebox;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UsersGridForEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/PianoProject;component/pages/admins/edituseradminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
            ((PianoProject.Pages.Admins.EditUserAdminPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.emailbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.phonebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.loginbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 199 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            case 6:
            this.passbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.idrolebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.UsersGridForEdit = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            
            #line 223 "..\..\..\..\Pages\Admins\EditUserAdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

