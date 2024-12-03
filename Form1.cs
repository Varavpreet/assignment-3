using System.ComponentModel;

namespace CricketTradingCards
{
    public partial class Form1 : Form
    {
        private BindingList<Player> players; // Use BindingList for automatic updates

        public Form1()
        {
            InitializeComponent();

            // Initialize controls as hidden
            pbPhoto.Visible = false;
            lblName.Visible = false;
            lblTeam.Visible = false;
            lblRuns.Visible = false;
            lblWickets.Visible = false;
            lblAverage.Visible = false;
            lblMatches.Visible = false;

            InitializeData(); // Populate data
            BindData();       // Bind data to ListBox
        }

        private void InitializeData()
        {
            players = new BindingList<Player>
            {
                // England Players
                new Player { Name = "Joe Root", Team = "England", PhotoPath = "photos/root.jpg", Runs = 11000, Wickets = 20, Matches = 150, Average = 50.2 },
                new Player { Name = "Ben Stokes", Team = "England", PhotoPath = "photos/stokes.jpg", Runs = 5000, Wickets = 150, Matches = 120, Average = 45.1 },
                new Player { Name = "Jos Buttler", Team = "England", PhotoPath = "photos/buttler.jpg", Runs = 6000, Wickets = 0, Matches = 140, Average = 40.6 },
                new Player { Name = "Jason Roy", Team = "England", PhotoPath = "photos/roy.jpg", Runs = 4000, Wickets = 0, Matches = 100, Average = 42.1 },
                new Player { Name = "Jofra Archer", Team = "England", PhotoPath = "photos/archer.jpg", Runs = 200, Wickets = 120, Matches = 60, Average = 18.3 },
                new Player { Name = "Jonny Bairstow", Team = "England", PhotoPath = "photos/bairstow.jpg", Runs = 5500, Wickets = 0, Matches = 120, Average = 41.8 },
                new Player { Name = "Chris Woakes", Team = "England", PhotoPath = "photos/woakes.jpg", Runs = 1500, Wickets = 250, Matches = 130, Average = 23.4 },
                new Player { Name = "Adil Rashid", Team = "England", PhotoPath = "photos/rashid.jpg", Runs = 800, Wickets = 300, Matches = 170, Average = 25.0 },
                new Player { Name = "Moeen Ali", Team = "England", PhotoPath = "photos/moeen.jpg", Runs = 3500, Wickets = 150, Matches = 120, Average = 32.3 },
                new Player { Name = "Mark Wood", Team = "England", PhotoPath = "photos/wood.jpg", Runs = 250, Wickets = 200, Matches = 90, Average = 21.2 },

                // Indian Players
                new Player { Name = "Virat Kohli", Team = "India", PhotoPath = "photos/virat.jpg", Runs = 12000, Wickets = 0, Matches = 280, Average = 59.3 },
                new Player { Name = "Rohit Sharma", Team = "India", PhotoPath = "photos/rohit.jpg", Runs = 10000, Wickets = 0, Matches = 230, Average = 48.7 },
                new Player { Name = "Jasprit Bumrah", Team = "India", PhotoPath = "photos/bumrah.jpg", Runs = 200, Wickets = 320, Matches = 100, Average = 15.5 },
                new Player { Name = "KL Rahul", Team = "India", PhotoPath = "photos/rahul.jpg", Runs = 6000, Wickets = 0, Matches = 150, Average = 46.8 },
                new Player { Name = "Hardik Pandya", Team = "India", PhotoPath = "photos/hardik.jpg", Runs = 3500, Wickets = 100, Matches = 130, Average = 37.4 },
                new Player { Name = "Shikhar Dhawan", Team = "India", PhotoPath = "photos/dhawan.jpg", Runs = 8000, Wickets = 0, Matches = 170, Average = 45.5 },
                new Player { Name = "Ravindra Jadeja", Team = "India", PhotoPath = "photos/jadeja.jpg", Runs = 4500, Wickets = 250, Matches = 180, Average = 34.2 },
                new Player { Name = "Mohammed Shami", Team = "India", PhotoPath = "photos/shami.jpg", Runs = 300, Wickets = 300, Matches = 120, Average = 20.6 },
                new Player { Name = "Suryakumar Yadav", Team = "India", PhotoPath = "photos/suryakumar.jpg", Runs = 1500, Wickets = 0, Matches = 50, Average = 38.2 },
                new Player { Name = "Yuzvendra Chahal", Team = "India", PhotoPath = "photos/chahal.jpg", Runs = 100, Wickets = 150, Matches = 110, Average = 25.1 },


                // Australia Players
                new Player { Name = "Steve Smith", Team = "Australia", PhotoPath = "photos/smith.jpg", Runs = 9000, Wickets = 10, Matches = 140, Average = 61.8 },
                new Player { Name = "David Warner", Team = "Australia", PhotoPath = "photos/warner.jpg", Runs = 8000, Wickets = 0, Matches = 160, Average = 48.7 },
                new Player { Name = "Pat Cummins", Team = "Australia", PhotoPath = "photos/cummins.jpg", Runs = 1000, Wickets = 220, Matches = 80, Average = 25.5 },
                new Player { Name = "Mitchell Starc", Team = "Australia", PhotoPath = "photos/starc.jpg", Runs = 500, Wickets = 300, Matches = 90, Average = 20.9 },
                new Player { Name = "Glenn Maxwell", Team = "Australia", PhotoPath = "photos/maxwell.jpg", Runs = 4500, Wickets = 50, Matches = 110, Average = 36.2 },
                new Player { Name = "Aaron Finch", Team = "Australia", PhotoPath = "photos/finch.jpg", Runs = 7000, Wickets = 0, Matches = 150, Average = 42.8 },
                new Player { Name = "Marcus Stoinis", Team = "Australia", PhotoPath = "photos/stoinis.jpg", Runs = 2500, Wickets = 100, Matches = 100, Average = 30.5 },
                new Player { Name = "Adam Zampa", Team = "Australia", PhotoPath = "photos/zampa.jpg", Runs = 200, Wickets = 180, Matches = 90, Average = 24.3 },
                new Player { Name = "Josh Hazlewood", Team = "Australia", PhotoPath = "photos/hazlewood.jpg", Runs = 300, Wickets = 200, Matches = 85, Average = 22.6 },
                new Player { Name = "Travis Head", Team = "Australia", PhotoPath = "photos/head.jpg", Runs = 3000, Wickets = 20, Matches = 90, Average = 40.3 }
            };
        }

        private void BindData()
        {
            listBoxPlayers.DataSource = players;
            listBoxPlayers.DisplayMember = "Name"; // Show the player's name in the ListBox
            listBoxPlayers.SelectedIndexChanged += ListBoxPlayers_SelectedIndexChanged;
        }

        private void ListBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                UpdatePlayerCard(selectedPlayer);
            }
        }

        private void UpdatePlayerCard(Player player)
        {
            // Show controls and update their values
            pbPhoto.Visible = true;
            lblName.Visible = true;
            lblTeam.Visible = true;
            lblRuns.Visible = true;
            lblWickets.Visible = true;
            lblAverage.Visible = true;
            lblMatches.Visible = true;

            lblName.Text = $"Name: {player.Name}";
            lblTeam.Text = $"Team: {player.Team}";
            lblRuns.Text = $"Runs: {player.Runs}";
            lblWickets.Text = $"Wickets: {player.Wickets}";
            lblMatches.Text = $"Matches: {player.Matches}";
            lblAverage.Text = $"Average: {player.Average:F2}";

            lblRuns.ForeColor = player.Runs > 8000 ? Color.Green : Color.Red;
            lblWickets.ForeColor = player.Wickets > 150 ? Color.Green : Color.Red;
            lblMatches.ForeColor = player.Matches > 150 ? Color.Green : Color.Red;
            lblAverage.ForeColor = player.Average > 50 ? Color.Green : Color.Red;

            if (File.Exists(player.PhotoPath))
            {
                pbPhoto.Image = Image.FromFile(player.PhotoPath);
                pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbPhoto.Image = null;
                MessageBox.Show($"Photo not found for {player.Name}");
            }

            switch (player.Team)
            {
                case "India":
                    background.BackColor = Color.Blue;
                    break;
                case "England":
                    background.BackColor = Color.LightPink;
                    break;
                case "Australia":
                    background.BackColor = Color.LightBlue;
                    break;
                default:
                    background.BackColor = Color.Green;
                    break;
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            players.Add(new Player
            {
                Name = "New Player",
                Team = "England",
                PhotoPath = "photos/newplayer.jpg",
                Runs = 1000,
                Wickets = 25,
                Matches = 30,
                Average = 50.5
            });

            MessageBox.Show("Player added successfully!");
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                players.Remove(selectedPlayer);
                MessageBox.Show($"{selectedPlayer.Name} removed successfully!");
            }
            else
            {
                MessageBox.Show("No player selected to remove!");
            }
        }
    }
}
