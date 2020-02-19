using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Lab1;

namespace Lab1GUI
{
	public partial class MainForm : Form
	{
		private enum ListType
		{
			CommonList, StudList, ProfList
		}

		private List<Person> commonList = new List<Person>();
		private List<Person> currentList;

		private Person currentRecord { get { return currentList[selectedIndex]; } }

		private int selectedIndex = 0;
		private ListType selectedList;

		private EditForm editForm;

		public MainForm()
		{
			//commonList.Add(new Stud("Сергей", "Петров", "Витальевич", "МОиАИС", "144-1", 4,
			//					new List<string>() { "Физика", "ООП", "История" }));
			//commonList.Add(new Stud("Анастасия", "Зуева", "Семёнова", "ПИ", "165", 2));
			//commonList.Add(new Prof("Владимир", "Азаров", "Михайлович", "Математики", 12,
			//					new List<string>() { "Математический анализ", "Топология", "Логика" }));

			InitializeComponent();
			currentList = commonList;
		}

		internal void RefreshCurrentList()
		{
			switch (selectedList)
			{
				case ListType.CommonList:
					currentList = commonList; break;
				case ListType.StudList:
					currentList = (from p in commonList where p is Stud select p).ToList(); break;
				case ListType.ProfList:
					currentList = (from p in commonList where p is Prof select p).ToList(); break;
			}

		}

		internal void AddRecord(Person person)
		{
			commonList.Add(person);
		}

		internal void DisplaySelectedRecord()
		{
			ClampSelectedIndex();
			if (currentList != null && currentList.Count > 0)
			{
				DisplayRecord(currentRecord);
			}
			else
			{
				ClearControls();
				CountLabel.Text = "0 / 0";
			}
		}

		internal void DisplayRecord(Person p)
		{
			NameTextBox.Text = p.Name;
			SurnameTextBox.Text = p.Surname;
			PatronymicTextBox.Text = p.Patronymic;
			YearTextBox.Text = p.Year.ToString();
			SubjectsListBox.Items.Clear();
			selectedIndex = currentList.IndexOf(p);

			if (p is Stud)
			{
				Stud student = p as Stud;
				YearLabel.Text = "Курс";
				SpecLabel.Text = "Специальность";
				SpecTextBox.Text = student.Spec;
				GroupLabel.Visible = true;
				GroupTextBox.Visible = true;
				GroupTextBox.Text = student.Group;
				SubjectsLabel.Text = "Несданные предметы:";

				foreach (var subject in student.Uncomms)
				{
					SubjectsListBox.Items.Add(subject);
				}
			}
			else if (p is Prof)
			{
				Prof professor = p as Prof;
				YearLabel.Text = "Стаж";
				SpecLabel.Text = "Кафедра";
				GroupLabel.Visible = false;
				GroupTextBox.Visible = false;
				SpecTextBox.Text = professor.Dep;
				SubjectsLabel.Text = "Читаемые курсы:";

				foreach (var subject in professor.Disciplines)
				{
					SubjectsListBox.Items.Add(subject);
				}
			}

			CountLabel.Text = $"{selectedIndex + 1} / {currentList.Count}";
		}

		public void WriteToBinaryFile(string filePath, object objectToWrite, bool append = false)
		{
			using (FileStream stream = new FileStream(filePath, append ? FileMode.Append : FileMode.Create))
			{
				var binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(stream, objectToWrite);
			}
		}

		public object ReadFromBinaryFile(string filePath)
		{
			try
			{
				using (FileStream stream = new FileStream(filePath, FileMode.Open))
				{
					var binaryFormatter = new BinaryFormatter();
					return binaryFormatter.Deserialize(stream);
				}
			}
			catch (FileNotFoundException ex)
			{
				MessageBox.Show("Файл List.txt не найден! Список не обновлен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		private void ListButton_Click(object sender, EventArgs e)
		{
			if (sender == StudListButton)
			{
				selectedList = ListType.StudList;
			}
			else if (sender == ProfListButton)
			{
				selectedList = ListType.ProfList;
			}
			else
			{
				selectedList = ListType.CommonList;
			}
			selectedIndex = 0;
			RefreshCurrentList();
			DisplaySelectedRecord();
		}

		private void SaveLoadButton_Click(object sender, EventArgs e)
		{
			if (sender == SaveButton)
			{
				WriteToBinaryFile("List.txt", commonList);
			}
			else if (sender == LoadButton)
			{
				List<Person> list = (List<Person>)ReadFromBinaryFile("List.txt");
				if (list != null)
				{
					commonList = list;
					selectedIndex = 0;
					selectedList = ListType.CommonList;
					RefreshCurrentList();
					DisplaySelectedRecord();
				}
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
		}

		private void NextYearButton_Click(object sender, EventArgs e)
		{
			if (currentList != null)
			{
				currentRecord.NextYear();
				DisplaySelectedRecord();
			}
		}

		private void NavButton_Click(object sender, EventArgs e)
		{
			if (currentList != null)
			{
				if (sender == ToBegButton)
				{
					selectedIndex = 0;
				}
				else if (sender == ToEndButton)
				{
					selectedIndex = currentList.Count - 1;
				}
				else if (sender == PrevButton)
				{
					--selectedIndex;
					ClampSelectedIndex();
				}
				else if (sender == NextButton)
				{
					++selectedIndex;
					ClampSelectedIndex();
				}

				DisplaySelectedRecord();
			}
		}

		private void ClearControls()
		{
			NameTextBox.Clear();
			SurnameTextBox.Clear();
			PatronymicTextBox.Clear();
			YearTextBox.Clear();
			SpecTextBox.Clear();
			GroupTextBox.Clear();
			SubjectsListBox.Items.Clear();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			editForm = new EditForm(this);

			if (sender == AddStudButton)
			{
				editForm.Show();
				editForm.LoadStud();
				editForm.Text = "Добавление студента";
				editForm.DisplayRecordInfo(new Stud());
			}
			else if (sender == AddProfButton)
			{
				editForm.Show();
				editForm.LoadProf();
				editForm.Text = "Добавление преподавателя";
				editForm.DisplayRecordInfo(new Prof());
			}
			else if (sender == EditButton)
			{
				editForm.Text = "Редактирование";
				if (currentList.Count != 0)
				{
					editForm.Show();
					editForm.DisplayRecordInfo(currentRecord);
					editForm.edit = true;
				}
				else
				{
					editForm.Close();
					MessageBox.Show("Не выбрана запись для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void ClampSelectedIndex()
		{
			if (selectedIndex < 0)
			{
				selectedIndex = 0;
			}
			else if (selectedIndex > currentList.Count - 1)
			{
				selectedIndex = currentList.Count - 1;
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			if (currentList.Count != 0)
			{
				if (currentList.Count == 1)
				{
					ClearControls();
				}

				commonList.Remove(currentRecord);
				RefreshCurrentList();
				ClampSelectedIndex();
				DisplaySelectedRecord();
			}
		}
	}
}
