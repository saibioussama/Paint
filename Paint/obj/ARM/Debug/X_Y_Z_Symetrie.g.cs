﻿#pragma checksum "C:\Users\SAIBIOUSSAMA\Documents\GitHub\Paint\Paint\X_Y_Z_Symetrie.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C82630C65211506014E6A0C6CC1AAC9B"
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
    partial class X_Y_Z_Symetrie : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Panel_Background(global::Windows.UI.Xaml.Controls.Panel obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
        };

        private class X_Y_Z_Symetrie_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IX_Y_Z_Symetrie_Bindings
        {
            private global::Paint.Models.ToolBarColor dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj8;

            public X_Y_Z_Symetrie_obj8_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8:
                        this.obj8 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::Paint.Models.ToolBarColor data = args.NewValue as global::Paint.Models.ToolBarColor;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::Paint.Models.ToolBarColor was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::Paint.Models.ToolBarColor);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Paint.Models.ToolBarColor) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IX_Y_Z_Symetrie_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // X_Y_Z_Symetrie_obj8_Bindings

            public void SetDataRoot(global::Paint.Models.ToolBarColor newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Paint.Models.ToolBarColor obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NameColor(obj.NameColor, phase);
                    }
                }
            }
            private void Update_NameColor(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Panel_Background(this.obj8.Target as global::Windows.UI.Xaml.Controls.Grid, (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), obj), null);
                }
            }
        }
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
                    #line 9 "..\..\..\X_Y_Z_Symetrie.xaml"
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
                    this.RestartButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 142 "..\..\..\X_Y_Z_Symetrie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RestartButton).Click += this.RestartButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.SmallPen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 145 "..\..\..\X_Y_Z_Symetrie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SmallPen).Click += this.SmallPen_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.BigPen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 148 "..\..\..\X_Y_Z_Symetrie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BigPen).Click += this.BigPen_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.HideBorder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 150 "..\..\..\X_Y_Z_Symetrie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HideBorder).Click += this.HideBorder_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.MyGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 122 "..\..\..\X_Y_Z_Symetrie.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.MyGridView).ItemClick += this.MyGridView_ItemClick;
                    #line default
                }
                break;
            case 9:
                {
                    this.Grid1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.Grid3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11:
                {
                    this.Grid4 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 12:
                {
                    this.Grid2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.Rect1 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 14:
                {
                    this.Rect2 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 15:
                {
                    this.Rect3 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 16:
                {
                    this.Rect4 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 17:
                {
                    this.InkCanvas3 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 18:
                {
                    this.InkCanvas4 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 19:
                {
                    this.InkCanvas7 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 20:
                {
                    this.InkCanvas8 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 21:
                {
                    this.InkCanvas5 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 22:
                {
                    this.InkCanvas6 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 23:
                {
                    this.InkCanvas1 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 24:
                {
                    this.InkCanvas2 = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
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
            switch(connectionId)
            {
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Grid element8 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    X_Y_Z_Symetrie_obj8_Bindings bindings = new X_Y_Z_Symetrie_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::Paint.Models.ToolBarColor) element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

