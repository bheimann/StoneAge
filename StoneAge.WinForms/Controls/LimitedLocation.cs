using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoneAge.Core;
using StoneAge.Core.Models;

namespace StoneAge.WinForms.Controls
{
    public class LimitedLocation : Button
    {
        public BoardSpace Space { get; set; }

        protected Game Game
        {
            get
            {
                return MainForm.Game;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            //Game.TryToOccupySpace(Space);

            //BackColor = Game.ColorOfSpace(Space).ToDrawingColor(SystemColors.Control);
        }
    }
}
