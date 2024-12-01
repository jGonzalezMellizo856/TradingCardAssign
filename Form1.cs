using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TradingCardAssign
{
    public partial class Form1 : Form
    {
        private List<TradingCard> tradingCards;
        // Dictionary to store team colors for visual feedback
        private Dictionary<string, Color> teamColors = new Dictionary<string, Color>()
        {
            { "Lakers", Color.Purple },
            { "Warriors", Color.Blue },
            { "Suns", Color.Orange },
            { "Celtics", Color.Green },
            { "Bucks", Color.DarkGreen }
        };

        public Form1()
        {
            InitializeComponent();
            tradingCards = TradingCardData.GetTradingCards();
            SetupListView();
            PopulateListView();
        }

        private void SetupListView()
        {
            player_Display.View = View.Details;
            player_Display.Columns.Add("Name", 150);
            player_Display.Columns.Add("Team", 100);
            player_Display.Columns.Add("PPG", 70);
        }

        private void PopulateListView()
        {
            player_Display.Items.Clear();

            foreach(var card in tradingCards)
            {
                var item = new ListViewItem(new[] { 
                    card.PlayerName,
                    card.Team,
                    card.PointsPerGame.ToString()
                });
                item.Tag = card;
                player_Display.Items.Add(item);
            }
        }

        private void player_Display_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player_Display.SelectedItems.Count > 0)
            {
                var selectedCard = player_Display.SelectedItems[0].Tag as TradingCard;

                if(selectedCard != null)
                {
                    // Update display with player info
                    pictureBox1.Visible = true;
                    playerNameLabel.Text = selectedCard.PlayerName;
                    teamNameLabel.Text = "Team: " + selectedCard.Team;

                    try
                    {
                        // Match player name with image resource name
                        string imageName = "";
                        if (selectedCard.PlayerName == "LeBron James")
                            imageName = "LeBron_James";
                        else if (selectedCard.PlayerName == "Anthony Davis")
                            imageName = "anthony_davis";
                        else if (selectedCard.PlayerName == "Stephen Curry")
                            imageName = "stephen-curry";
                        else if (selectedCard.PlayerName == "Klay Thompson")
                            imageName = "klay-thompson";
                        else if (selectedCard.PlayerName == "Giannis Antetokounmpo")
                            imageName = "Giannis_Antetokounmpo";
                        else if (selectedCard.PlayerName == "Devin Booker")
                            imageName = "devin_booker";
                        else if (selectedCard.PlayerName == "Jayson Tatum")
                            imageName = "jayson_tatum";
                        else if (selectedCard.PlayerName == "Jaylen Brown")
                            imageName = "jaylen_brown";
                        else if (selectedCard.PlayerName == "Damian Lillard")
                            imageName = "damian_lillard";
                        else if (selectedCard.PlayerName == "Kevin Durant")
                            imageName = "kevin_durant";
                        else
                            imageName = selectedCard.ImagePath;

                        // Load and display player image
                        var image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image != null)
                        {
                            pictureBox1.Image = (System.Drawing.Image)image;
                        }
                    }
                    catch
                    {
                        // Create fallback image if player image not found
                        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                        {
                            g.Clear(Color.LightGray);
                            g.DrawString(selectedCard.PlayerName, 
                                new Font("Arial", 16), 
                                Brushes.Black, 
                                new Point(10, 10));
                        }
                    }

                    ShowPlayerStats(selectedCard);

                    // Apply team color theme
                    if (teamColors.ContainsKey(selectedCard.Team))
                    {
                        Color teamColor = teamColors[selectedCard.Team];
                        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                        pictureBox1.BackColor = teamColor;
                        // Create lighter version of team color for background
                        this.BackColor = Color.FromArgb(
                            (teamColor.R + 255) / 2,
                            (teamColor.G + 255) / 2,
                            (teamColor.B + 255) / 2
                        );
                        player_Display.BackColor = Color.White;
                    }
                }
            }
        }

        private void ShowPlayerStats(TradingCard card)
        {
            // Display stats and highlight above-average stats in green
            pointsLabel.Text = "Points: " + card.PointsPerGame;
            pointsLabel.ForeColor = card.PointsPerGame > 25 ? Color.Green : Color.Black;

            reboundsLabel.Text = "Rebounds: " + card.ReboundsPerGame;
            reboundsLabel.ForeColor = card.ReboundsPerGame > 7 ? Color.Green : Color.Black;

            assistLabel.Text = "Assists: " + card.AssistsPerGame;
            assistLabel.ForeColor = card.AssistsPerGame > 5 ? Color.Green : Color.Black;

            stealsLabel.Text = "Steals: " + card.StealsPerGame;
            stealsLabel.ForeColor = card.StealsPerGame > 1 ? Color.Green : Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
