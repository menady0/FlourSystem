using CuoreUI.Controls;
using FlourSystem.Classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlourSystem.Forms.User_Control
{
    public partial class ucTeam : UserControl
    {
        cuiBorder[] RightCards;
        cuiBorder[] RightSocial;

        cuiBorder[] LeftCards;
        cuiBorder[] LeftSocial;
        public ucTeam()
        {
            InitializeComponent();

            LeftCards = new cuiBorder[]
            {
                pnlCard1,
                pnlCard3,
                pnlCard6,
                pnlCard8,
            };
            LeftSocial = new cuiBorder[]
            {
                pnlSocialMedia1,
                pnlSocialMedia3,
                pnlSocialMedia6,
                pnlSocialMedia8,
            };

            RightCards = new cuiBorder[]
            {
                pnlCard2,
                pnlCard4,
                pnlCard5,
                pnlCard7,
            };
            RightSocial = new cuiBorder[]
            {
                pnlSocialMedia2,
                pnlSocialMedia4,
                pnlSocialMedia5,
                pnlSocialMedia7,
            };
        }
        private void picLinkedIn_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/mena-nady";
            goToLink(url);
        }
        void goToLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open link. {ex.Message}");
            }
        }

        private void ucTeam_Load(object sender, EventArgs e)
        {
            HoverEffect.HoverWithChainedTransition
            (
                LeftCards,
                getHoverValue1: ctrl => new Padding(5, 5, 5, 5),
                getDefaultValue1: ctrl => new Padding(125, 5, 125, 5),
                setValue1: (ctrl, value) =>
                {
                    if (ctrl is cuiBorder panel)
                        panel.Rounding = value;
                },
                interpolate1: (start, end, progress) => new Padding(
                    HoverEffect.InterpolateInt(start.Left, end.Left, progress),
                    HoverEffect.InterpolateInt(start.Top, end.Top, progress),
                    HoverEffect.InterpolateInt(start.Right, end.Right, progress),
                    HoverEffect.InterpolateInt(start.Bottom, end.Bottom, progress)
                ),


                LeftSocial,
                getDefaultValue2: ctrl => new Point(12, 275),
                getHoverValue2: ctrl => new Point(12, 240),
                setValue2: (ctrl, value) =>
                {
                    if (ctrl is cuiBorder panel)
                        panel.Location = value;
                },
                interpolate2: (start, end, progress) => new Point(
                    HoverEffect.InterpolateInt(start.X, end.X, progress),
                    HoverEffect.InterpolateInt(start.Y, end.Y, progress)
                ),

                transitionDuration: 250
            );
            HoverEffect.HoverWithChainedTransition
            (
                RightCards,
                getHoverValue1: ctrl => new Padding(5, 5, 5, 5),
                getDefaultValue1: ctrl => new Padding(5, 125, 5, 125),
                setValue1: (ctrl, value) =>
                {
                    if (ctrl is cuiBorder panel)
                        panel.Rounding = value;
                },
                interpolate1: (start, end, progress) => new Padding(
                    HoverEffect.InterpolateInt(start.Left, end.Left, progress),
                    HoverEffect.InterpolateInt(start.Top, end.Top, progress),
                    HoverEffect.InterpolateInt(start.Right, end.Right, progress),
                    HoverEffect.InterpolateInt(start.Bottom, end.Bottom, progress)
                ),


                RightSocial,
                getDefaultValue2: ctrl => new Point(12, 275),
                getHoverValue2: ctrl => new Point(12, 240),
                setValue2: (ctrl, value) =>
                {
                    if (ctrl is cuiBorder panel)
                        panel.Location = value;
                },
                interpolate2: (start, end, progress) => new Point(
                    HoverEffect.InterpolateInt(start.X, end.X, progress),
                    HoverEffect.InterpolateInt(start.Y, end.Y, progress)
                ),

                transitionDuration: 250
            );
            ThemeManager.ApplyTheme();
        }


    }
}
