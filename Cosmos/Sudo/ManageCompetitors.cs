using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cosmos.Sudo
{
    public partial class ManageCompetitors : Form
    {
        List<Competitor> competitors = new List<Competitor>();
        private Competitor originalCompetitor = null;
        private bool isNewCompetitor = false;

        public ManageCompetitors(List<Competitor> comp)
        {
            InitializeComponent();

            competitors = comp;
            LoadCompetitors();
        }

        private void LoadCompetitors()
        {
            lstCompetitors.Items.Clear();
            foreach (var competitor in competitors)
            {
                lstCompetitors.Items.Add(competitor.name);
            }
        }

        private void LoadDetails(Competitor competitor)
        {
            if (competitor != null)
            {
                tbName.Text = competitor.name;
                tbNationality.Text = competitor.nationality;

                switch (competitor.type)
                {
                    case 1:
                        cbType.SelectedIndex = 1; // Ninja
                        break;
                    case 2:
                        cbType.SelectedIndex = 2; // OCR
                        break;
                    case 3:
                        cbType.SelectedIndex = 3; // Sportsman
                        break;
                    case 4:
                        cbType.SelectedIndex = 4; // Climber
                        break;
                    case 5:
                        cbType.SelectedIndex = 5; // Fictional
                        break;
                    default:
                        cbType.SelectedIndex = 0; // Unknown
                        break;
                }

                if (competitor.isFemale)
                {
                    cbGender.SelectedIndex = 1;
                }
                else
                {
                    cbGender.SelectedIndex = 0;
                }

                nudSpeed.Value = competitor.speed;
                nudTech.Value = competitor.tech;
                nudGrip.Value = competitor.grip;
                nudStrength.Value = competitor.strength;
                nudEndurance.Value = competitor.endurance;
                nudAgility.Value = competitor.agility;
                nudBalance.Value = competitor.balance;
                nudLache.Value = competitor.lache;
                nudStamina.Value = competitor.stamina;
                nudIntelligence.Value = competitor.intelligence;

                ToggleTextFields(true);
            }
            else
            {
                tbName.Clear();
                tbNationality.Clear();
                cbType.ResetText();
                cbGender.ResetText();
                nudSpeed.ResetText();
                nudTech.ResetText();
                nudGrip.ResetText();
                nudStrength.ResetText();
                nudEndurance.ResetText();
                nudAgility.ResetText();
                nudBalance.ResetText();
                nudLache.ResetText();
                nudStamina.ResetText();
                nudIntelligence.ResetText();

                ToggleTextFields(false);
            }
        }

        private void ToggleTextFields(bool enabled)
        {
            tbName.Enabled = enabled;
            tbNationality.Enabled = enabled;
            cbType.Enabled = enabled;
            cbGender.Enabled = enabled;
            nudSpeed.Enabled = enabled;
            nudTech.Enabled = enabled;
            nudGrip.Enabled = enabled;
            nudStrength.Enabled = enabled;
            nudEndurance.Enabled = enabled;
            nudAgility.Enabled = enabled;
            nudBalance.Enabled = enabled;
            nudLache.Enabled = enabled;
            nudStamina.Enabled = enabled;
            nudIntelligence.Enabled = enabled;
        }

        private void CheckForChanges()
        {
            if (originalCompetitor == null)
            {
                btnSave.Enabled = false;
                btnReset.Enabled = false;
                return;
            }

            bool changed = 
                tbName.Text != originalCompetitor.name ||
                tbNationality.Text != originalCompetitor.nationality ||
                cbType.SelectedIndex != originalCompetitor.type ||
                cbGender.SelectedIndex != (originalCompetitor.isFemale ? 1 : 0) ||
                nudSpeed.Value != originalCompetitor.speed ||
                nudTech.Value != originalCompetitor.tech ||
                nudGrip.Value != originalCompetitor.grip ||
                nudStrength.Value != originalCompetitor.strength ||
                nudEndurance.Value != originalCompetitor.endurance ||
                nudAgility.Value != originalCompetitor.agility ||
                nudBalance.Value != originalCompetitor.balance ||
                nudLache.Value != originalCompetitor.lache ||
                nudStamina.Value != originalCompetitor.stamina ||
                nudIntelligence.Value != originalCompetitor.intelligence;
            
            btnSave.Enabled = changed;
            btnReset.Enabled = changed;
        }

        private void SaveChanges()
        {
            bool isFemale;
            if (cbGender.SelectedIndex == 0)
                isFemale = false;
            else
                isFemale = true;

            if (isNewCompetitor)
            {
                Competitor newCompetitor = Competitor.CreateFromForm(
                    competitors.Count + 1, tbName.Text, (int)nudSpeed.Value,
                    (int)nudTech.Value, (int)nudGrip.Value, (int)nudStrength.Value,
                    (int)nudEndurance.Value, (int)nudAgility.Value,
                    (int)nudBalance.Value, (int)nudLache.Value,
                    (int)nudStamina.Value, (int)nudIntelligence.Value,
                    tbNationality.Text, cbType.SelectedIndex, isFemale);
                competitors.Add(newCompetitor);

                lstCompetitors.Items.Add(newCompetitor.name);
                lstCompetitors.Enabled = true;
                MessageBox.Show("New competitor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDetails(null);
            }
            else
            {
                int i = lstCompetitors.SelectedIndex;
                if (i >= 0 && i < competitors.Count)
                {
                    Competitor updated = Competitor.CreateFromForm(
                        originalCompetitor.ID, tbName.Text, (int)nudSpeed.Value,
                        (int)nudTech.Value, (int)nudGrip.Value, (int)nudStrength.Value,
                        (int)nudEndurance.Value, (int)nudAgility.Value,
                        (int)nudBalance.Value, (int)nudLache.Value,
                        (int)nudStamina.Value, (int)nudIntelligence.Value,
                        tbNationality.Text, cbType.SelectedIndex,
                        isFemale);
                    competitors[i] = updated;
                    lstCompetitors.Items[i] = updated.name;
                    originalCompetitor = new Competitor(
                        updated.ID, updated.name,
                        updated.speed, updated.tech, updated.grip, updated.strength,
                        updated.endurance, updated.agility, updated.balance,
                        updated.lache, updated.stamina, updated.intelligence,
                        updated.nationality, updated.type, updated.isFemale);
                    MessageBox.Show("Competitor details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(tbNationality.Text))
            {
                MessageBox.Show("Nationality cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (cbType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a competitor type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (cbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lstCompetitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstCompetitors.SelectedIndex;
            if (i >= 0 && i < competitors.Count)
            {
                originalCompetitor = competitors[i];
                LoadDetails(originalCompetitor);
                btnDeleteCompetitor.Enabled = true;
            }
        }

        private void AnyFieldChanged(object sender, EventArgs e)
        {
            CheckForChanges();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isNewCompetitor)
            {
                ToggleTextFields(false);
                lstCompetitors.ClearSelected();
                lstCompetitors.Enabled = true;
                isNewCompetitor = false;
                originalCompetitor = null;
                LoadDetails(null);
            }
            else
            {
                LoadDetails(originalCompetitor);
            }
            CheckForChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasValidationError = ValidateFields();
            if (hasValidationError)
            {
                return; // Stop saving if validation fails
            }
            SaveChanges();
        }
    }
}
