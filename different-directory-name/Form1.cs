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

namespace TradingCardAssign
{
    public partial class Form1 : Form
    {
        private List<TradingCard> tradingCards;

        public Form1()
        {
            InitializeComponent();
            tradingCards = TradingCardData.GetTradingCards();
            PopulateListView();

        }

        private void PopulateListView()
        {
            player_Display.Items.Clear();

            foreach(var card in tradingCards)
            {
                var item = new ListViewItem(card.PlayerName);
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
                    playerNameLabel.Text = selectedCard.PlayerName;
                    teamNameLabel.Text = selectedCard.Team;
                    pictureBox1.ImageLocation = selectedCard.ImagePath;
                    pointsLabel.Text = $"Points/Game: {selectedCard.PointsPerGame}";
                    reboundsLabel.Text = $"Rebounds/Game: {selectedCard.ReboundsPerGame}";
                    assistLabel.Text = $"Assists/Game: {selectedCard.AssistsPerGame}";
                    stealsLabel.Text = $"Steals/Game: {selectedCard.StealsPerGame}";
                }
            }
        }


       
    }
}
