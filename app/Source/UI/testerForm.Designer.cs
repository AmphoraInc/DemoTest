//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Diagnostics;


namespace NSTester {
    
    public partial class testerForm : RibbonForm {
        #region fields
        /// <summary>
        /// Required designer variable.
        /// </summary>
        IContainer components = null;
        RibbonControl ribbonControl;
        RibbonPage ribbonPage;
        RibbonPageGroup ribbonPageGroup;
        BarButtonItem bbExit;
        BarButtonItem bbAbout;
        RibbonStatusBar ribbonStatusBar;
        #endregion
        #region Windows Form Designer generated code
        /// <summary>Required method for Designer support</summary>
        void InitializeComponent() {
            this.ribbonControl = new RibbonControl();
            this.ribbonPage = new RibbonPage();
            this.ribbonPageGroup = new RibbonPageGroup();
            this.bbExit = new BarButtonItem();
            this.bbAbout = new BarButtonItem();
            this.ribbonStatusBar = new RibbonStatusBar();
            this.ribbonPage.Groups.Add(this.ribbonPageGroup);
            this.ribbonControl.Pages.Add(this.ribbonPage);
            this.ribbonControl.Items.Add(this.bbExit);
            this.ribbonControl.Items.Add(this.bbAbout);
            this.ribbonPage.Text = "File";
            this.ribbonPageGroup.Text = "File";
            this.ribbonControl.PageHeaderItemLinks.Add(this.bbAbout);
            this.ribbonPageGroup.ItemLinks.Add(this.bbExit);
            this.bbExit.Caption = "Exit";
            this.bbExit.Name = "bbExit";
            this.bbExit.ItemClick += new ItemClickEventHandler(this.exitApp);
            this.bbAbout.Name = "bbAbout";
            this.bbAbout.ItemClick += new ItemClickEventHandler(this.showAbout);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Load += new System.EventHandler(this.formLoad);
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            //            this.AutoHideRibbon = false;
            //            this.ribbonbv
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
        }
        #endregion
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if ((components != null)) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
