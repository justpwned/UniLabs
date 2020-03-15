using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Home
{
	public class Subscriber
	{
		public string Name { get; }
		public List<Publication> Subscriptions { get; } = new List<Publication>();
		public SubscriberForm Form { get; }

		public Subscriber(string name, PublisherForm parentForm)
		{
			Name = name;
			Form = new SubscriberForm(parentForm, this);
		}

		public void ShowForm()
		{
			Form.Show();
		}

		public void SubscribeTo(Publication pub)
		{
			if (!Subscriptions.Contains(pub))
			{
				try
				{
					EventSystem.Register(pub.Name, Form, EventHandler);

					Subscriptions.Add(pub);
					Form.RefreshTooltip();
					if (pub is Newspaper)
					{
						Form.ParentForm.Log($"Подписчик {Name} подписался на газету «{pub.Name}»");
						Form.Log($"Оформлена подписка на газету «{pub.Name}»");
					} 
					else if (pub is Magazine)
					{
						Form.ParentForm.Log($"Подписчик {Name} подписался на журнал «{pub.Name}»");
						Form.Log($"Оформлена подписка на журнал «{pub.Name}»");
					}

					if (!pub.Subscribers.Contains(this))
					{
						pub.Subscribers.Add(this);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

		}

		public void UnsubsribeFrom(Publication pub, bool silent = false)
		{
			if (Subscriptions.Contains(pub))
			{
				try
				{
					EventSystem.UnRegister(pub.Name, Form, EventHandler);

					Subscriptions.Remove(pub);
					Form.RefreshTooltip();
					if (pub is Newspaper)
					{
						Form.ParentForm.Log($"Подписчик {Name} аннулировал подписку на газету «{pub.Name}»");
						Form.Log($"Аннулирована подписка на газету «{pub.Name}»");
					}
					else if (pub is Magazine)
					{
						Form.ParentForm.Log($"Подписчик {Name} аннулировал подписку на журнал «{pub.Name}»");
						Form.Log($"Аннаулирована подписка на журнал «{pub.Name}»");
					}

					if (pub.Subscribers.Contains(this))
					{
						pub.Subscribers.Remove(this);
					}
					
				}
				catch (Exception e)
				{
					if (!silent)
					{
						if (pub is Newspaper)
						{
							MessageBox.Show($"«{Name}» не подписан на газету «{pub.Name}»");
						}
						else if (pub is Magazine)
						{
							MessageBox.Show($"«{Name}» не подписан на журнал «{pub.Name}»", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
		}

		private void EventHandler(Publication pub)
		{
			if (pub is Newspaper)
			{
				Form.Log($"Получена газета «{pub.Name}» №{pub.Num}");
			}
			else if (pub is Magazine)
			{
				Form.Log($"Получен журанал «{pub.Name}» №{pub.Num}");
			}
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
