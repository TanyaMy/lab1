﻿#pragma checksum "C:\Work\NURE\ComputerHumanInteraction\Lab1\Lab1\Views\Menu\FactsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "809952F07135639A017AF95DE823FDF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1
{
    partial class FactsPage : 
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
                    this.text = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.Cont = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.factsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\..\Views\Menu\FactsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.factsBtn).Click += this.factsBtn_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.contactBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\..\Views\Menu\FactsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.contactBtn).Click += this.contactBtn_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.regBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\..\Views\Menu\FactsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.regBtn).Click += this.regBtn_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.mainBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\..\Views\Menu\FactsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.mainBtn).Click += this.mainBtn_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

