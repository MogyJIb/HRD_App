using HRD_App.Errors;
using HRD_App.Rest;
using HRD_App.Utils;
using HRD_DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_App.Forms
{
    public partial class RewardsForm : Form
    {
        private BindingList<Reward> rewards;

        public RewardsForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        public void init()
        {
            rewards = new BindingList<Reward>();
            dataGridView_rewards.DataSource = rewards;
            dataGridView_rewards.Columns["Deleted"].Visible = false;
            dataGridView_rewards.Columns["Employee"].Visible = false;
            dataGridView_rewards.Columns["EmployeeName"].Visible = false;


            AddRewards(RestApi.RewardService.GetAll(false).Result);
            dataGridView_rewards.Refresh();
        }

        private void AddRewards(List<Reward> rewards)
        {
            rewards
                    .OrderBy(t => t.RewardId)
                    .ToList()
                    .ForEach(d => this.rewards.Add(d));
        }

        private void UpdateReward(Reward newReward)
        {
            Reward oldReward = rewards
                .Where(d => d.RewardId == newReward.RewardId)
                .FirstOrDefault();

            if (oldReward == null) return;

            oldReward.EmployeeId = newReward.EmployeeId;
            oldReward.Date = newReward.Date;
            oldReward.Amount = newReward.Amount;
            oldReward.Reason = newReward.Reason;
            oldReward.Deleted = newReward.Deleted;
            oldReward.Employee = newReward.Employee;
        }

        private void DeleteReward(Reward reward)
        {
            reward = rewards
                    .Where(d => d.RewardId == reward.RewardId)
                    .FirstOrDefault();

            if (reward != null)
                rewards.Remove(reward);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (rewards.Count < 1) return;

            int row = dataGridView_rewards.CurrentRow.Index;
            int id = (int)dataGridView_rewards[0, row].Value;
            new UpdateRewardsForm(id, true)
                .SetOnValueChangedListener(reward =>
                {
                    UpdateReward(reward);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (rewards.Count < 1) return;

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_rewards.CurrentRow.Index;
                int id = (int)dataGridView_rewards[0, row].Value;

                try
                {
                    Reward reward = await RestApi.RewardService.Delete(id);
                    DeleteReward(reward);
                    Filter();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            new UpdateRewardsForm(-1, true)
                .SetOnValueChangedListener(reward =>
                {
                    rewards.Add(reward);
                    Filter();
                })
                .ShowDialog();
        }

        private async void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            string pattern = textBox_search.Text;
            if (pattern == "" || pattern == "Поиск")
                dataGridView_rewards.DataSource = rewards;
            else
                dataGridView_rewards.DataSource =
                    rewards.Where(d => d.RewardId.ToString().Contains(pattern)
                                                || d.EmployeeId.ToString().Contains(pattern)
                                                || d.Date.ToString().Contains(pattern)
                                                || d.Amount.ToString().Contains(pattern)
                                                || d.Reason.ToString().Contains(pattern)
                                ).ToList();
        }


        private void textBox_search_Enter(object sender, EventArgs e)
        {
            if (textBox_search.ForeColor == Color.Black)
                return;
            textBox_search.Text = "";
            textBox_search.ForeColor = Color.Black;
        }

        private void textBox_search_Leave(object sender, EventArgs e)
        {
            if (textBox_search.Text == "")
            {
                textBox_search.ForeColor = Color.Gray;
                textBox_search.Text = "Поиск";
            }
        }
    }
}