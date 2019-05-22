﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkiaSharp;

namespace Modern.Forms
{
    public class MessageBoxForm : ModernForm
    {
        private ModernFormTitleBar titlebar;
        private string text;
        private Label label;

        public MessageBoxForm ()
        {
            Text = "Demo";
            StartPosition = FormStartPosition.CenterParent;

            titlebar = new ModernFormTitleBar {
                Text = "Demo",
                AllowMinimize = false,
                AllowMaximize = false
            };

            Controls.Add (titlebar);

            label = new Label {
                Width = 397,
                Left = 1,
                Top = 50
            };

            label.Style.BackgroundColor = SKColors.White;
            label.Style.FontSize = 16;

            Controls.Add (label);

            var button = new Button {
                Text = "OK",
                Left = 150,
                Top = 150
            };

            button.Click += (o, e) => Close ();

            Controls.Add (button);
        }

        protected override Size DefaultSize => new Size (400, 200);

        public MessageBoxForm (string title, string text) : this ()
        {
            Text = title;
            titlebar.Text = title;
            this.text = text;

            label.Text = text;
        }
    }
}
