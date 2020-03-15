using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4Home
{
	public class Event
	{
		public Action<Publication> Methods { get; set; }
		public int CountMethods
		{
			get
			{
				if (Methods == null)
				{
					return 0;
				}
				return Methods.GetInvocationList().Count();
			}
		}
	};

	public static class EventSystem
	{
		private static Dictionary<string, Event> events = new Dictionary<string, Event>();
		private static List<object> observers = new List<object>();


		public static void AddEvent(string eventName)
		{
			if (events.ContainsKey(eventName))
			{
				throw new Exception($"Event {eventName} already exists!");
			}

			events.Add(eventName, new Event());
		}

		public static void DeleteEvent(string eventName)
		{
			if (!events.ContainsKey(eventName))
			{
				throw new Exception($"Event {eventName} doesn't exist!");
			}

			events.Remove(eventName);

			// Alert all the observers of this event about its deletion
		}

		public static int GetNumberOfSubs(string eventName)
		{
			if (events.ContainsKey(eventName))
			{
				return events[eventName].CountMethods;
			}

			return 0;
		}

		public static void TriggerEvent(string eventName, Publication pub)
		{
			if (!events.ContainsKey(eventName))
			{
				throw new Exception($"Event {eventName} doesn't exist!");
			}

			events[eventName].Methods?.Invoke(pub);
		}

		public static void RemoveObserver(object obsObj)
		{
			observers.Remove(obsObj);

			foreach (var e in events)
			{
				if (e.Value.Methods != null)
				{
					foreach (var method in e.Value.Methods.GetInvocationList())
					{
						if (method.Target == obsObj)
						{
							UnRegister(e.Key, obsObj, (Action<Publication>)method);
						}
					}
				}
			}
		}

		public static void Register(string eventName, object subObj, Action<Publication> method)
		{
			if (!events.ContainsKey(eventName))
			{
				throw new Exception($"Event {eventName} doesn't exist!");
			}

			events[eventName].Methods += method;
		}

		public static void UnRegister(string eventName, object subObj, Action<Publication> method)
		{
			bool done = false;

			if (events.ContainsKey(eventName))
			{
				done = false;

				if (events[eventName].Methods != null)
				{
					foreach (var i in events[eventName].Methods.GetInvocationList())
					{
						if ((Delegate)method == i)
						{
							done = true;
							break;
						}
					}
				}
			}

			if (done)
			{
				events[eventName].Methods -= method;
			}
			else
			{
				throw new Exception("Error!");
			}
		}
	}
}
