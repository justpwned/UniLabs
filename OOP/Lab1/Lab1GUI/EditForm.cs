using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1;

namespace Lab1GUI
{
	public partial class EditForm : Form
	{
		private Person currentPerson;
		private MainForm parent;

		private bool _edit;
		internal bool edit
		{
			get { return _edit; }
			set
			{
				_edit = value;
				if (value) AddEntryButton.Text = "Изменить";
				else AddEntryButton.Text = "Добавить";
			}
		}


		public EditForm(MainForm parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private void EditFormButtons_Click(object sender, EventArgs e)
		{
			if (sender == AddEntryButton)
			{
				bool parsed = int.TryParse(YearTextBox.Text, out int year);
				if (currentPerson is Stud)
				{
					if (parsed && year >= 1 && year <= 4)
					{
						Stud stud = currentPerson as Stud;
						stud.Name = NameTextBox.Text;
						stud.Surname = SurnameTextBox.Text;
						stud.Patronymic = PatronymicTextBox.Text;
						stud.Spec = SpecTextBox.Text;
						stud.Group = GroupTextBox.Text;
						stud.Year = year;
						stud.Uncomms = SubjectsTextBox.Text.Split(new char[] { '\n', '\r' }, 
							StringSplitOptions.RemoveEmptyEntries).ToList<string>();

						if (!edit)
						{
							parent.AddRecord(stud);
							parent.RefreshCurrentList();
						}

						parent.DisplayRecord(stud);

						this.Close();
					}
					else
					{
						MessageBox.Show("Значение поля \"Курс\" должно быть числом между 1 и 4 включительно",
										"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else if (currentPerson is Prof)
				{
					Prof prof = currentPerson as Prof;
					prof.Name = NameTextBox.Text;
					prof.Surname = SurnameTextBox.Text;
					prof.Patronymic = PatronymicTextBox.Text;
					prof.Dep = SpecTextBox.Text;
					prof.Year = year;
					prof.Disciplines = SubjectsTextBox.Text.Split(new char[] { '\n', '\r' }, 
						StringSplitOptions.RemoveEmptyEntries).ToList<string>();

					if (!edit)
					{
						parent.AddRecord(currentPerson);
						parent.RefreshCurrentList();
					}

					parent.DisplayRecord(prof);

					this.Close();
				}
			}
			else if (sender == CancelEntryButton)
			{
				this.Close();
			}
		}

		public void DisplayRecordInfo(Person person)
		{
			currentPerson = person;
			if (person is Stud)
			{
				DisplayStudInfo(person as Stud);
			}
			else if (person is Prof)
			{
				DisplayProfInfo(person as Prof);
			}
		}

		private void DisplayPersonInfo(Person person)
		{
			NameTextBox.Text = person.Name;
			SurnameTextBox.Text = person.Surname;
			PatronymicTextBox.Text = person.Patronymic;
			YearTextBox.Text = person.Year == 0 ? "" : person.Year.ToString();
		}

		public void LoadStud()
		{
			YearLabel.Text = "Курс";
			SubjectsLabel.Text = "Несданные предметы:";
		}

		private void DisplayStudInfo(Stud student)
		{
			LoadStud();
			DisplayPersonInfo(student);
			SpecTextBox.Text = student.Spec;
			GroupTextBox.Text = student.Group;
			SubjectsTextBox.Text = student.Uncomms.Repr("\n");
		}

		public void LoadProf()
		{
			YearLabel.Text = "Стаж";
			SpecLabel.Text = "Кафедра";
			GroupLabel.Visible = false;
			GroupTextBox.Text = "test";
			GroupTextBox.Visible = false;
			SubjectsLabel.Text = "Читаемые курсы:";
		}

		private void DisplayProfInfo(Prof prof)
		{
			LoadProf();
			DisplayPersonInfo(prof);
			SpecTextBox.Text = prof.Dep;
			SubjectsTextBox.Text = prof.Disciplines.Repr("\n");
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || PatronymicTextBox.Text == "" ||
				YearTextBox.Text == "" || SpecTextBox.Text == "" || GroupTextBox.Text == "")
			{
				AddEntryButton.Enabled = false;
			}
			else
			{
				AddEntryButton.Enabled = true;
			}
		}

		private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Back)
			{
				return;
			}

			if (!(char.IsLetter(e.KeyChar)))
			{
				e.Handled = true;
			}

			if (e.KeyChar == (char)Keys.Enter)
			{
				if (sender == NameTextBox) SurnameTextBox.Focus();
				else if (sender == SurnameTextBox) PatronymicTextBox.Focus();
				else if (sender == PatronymicTextBox) YearTextBox.Focus();
			}
		}

		private void YearTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Back)
			{
				return;
			}

			if (currentPerson is Stud)
			{
				if (!(char.IsDigit(e.KeyChar)) || e.KeyChar == '0' && (sender as TextBox).Text == "")
				{
					e.Handled = true;
				}
			}
			else if (currentPerson is Prof)
			{
				if (!(char.IsDigit(e.KeyChar)) || e.KeyChar == '0' && (sender as TextBox).Text == "0")
				{
					e.Handled = true;
				}
			}

			if (e.KeyChar == (char)Keys.Enter)
			{
				SpecTextBox.Focus();
			}
		}

		private void SpecTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				if (currentPerson is Stud)
				{
					if (sender == SpecTextBox) GroupTextBox.Focus();
					else if (sender == GroupTextBox) SubjectsTextBox.Focus();
				}
				else if (currentPerson is Prof)
				{
					if (sender == SpecTextBox) SubjectsTextBox.Focus();
				}
				e.Handled = true;
			}
		}

		private void SubjectsTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Back) return;
			if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Enter || 
				  char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Space))
			{
				e.Handled = true;
			}
		}

		private void EditForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
