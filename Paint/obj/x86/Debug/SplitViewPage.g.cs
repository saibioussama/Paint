﻿#pragma checksum "C:\Users\SAIBIOUSSAMA\Documents\GitHub\Paint\Paint\SplitViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "775464FCE96BE8A08C2E082C21D799FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Paint
{
    partial class SplitViewPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\SplitViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.Grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\SplitViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MyListView1 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 6:
                {
                    this.MyListView2 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 43 "..\..\..\SplitViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.MyListView2).Tapped += this.MyListView2_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.ListBoxItem element7 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                    #line 30 "..\..\..\SplitViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBoxItem)element7).Tapped += this.ListBoxItem_Tapped;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.ListBoxItem element8 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                    #line 36 "..\..\..\SplitViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBoxItem)element8).Tapped += this.ListBoxItem_Tapped_1;
                    #line default
                }
                break;
            case 9:
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

