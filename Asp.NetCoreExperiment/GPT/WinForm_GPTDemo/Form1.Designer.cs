﻿using System.ComponentModel;

namespace WinForm_GPTDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;


        //参照name_display_Lab和name_Lab，生成person各属性，并且要有Label的具本定义，位置横向排列




        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            propertyGrid1 = new PropertyGrid();
            button1 = new Button();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(413, 38);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = button1;
            propertyGrid1.Size = new Size(333, 530);
            propertyGrid1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(144, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 642);
            Controls.Add(button1);
            Controls.Add(propertyGrid1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid1;
        private Button button1;
    }


    //-----------------------------------------------------



}