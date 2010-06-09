
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Logos4ComApiDemo.Properties;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			// store the single instance of the main form
			s_instance = this;

			InitializeComponent();
		}

		public static MainForm Instance
		{
			get { return s_instance; }
		}

		public LogosLauncher LogosLauncher
		{
			get { return m_launcher; }
		}

		public LogosApplication LogosApplication
		{
			get { return m_app; }
		}

		public DataTypeForm DataTypeForm
		{
			get
			{
				if (m_dataTypeForm != null && m_dataTypeForm.Visible)
					return m_dataTypeForm;

				m_dataTypeForm = new DataTypeForm();
				m_dataTypeForm.Show();
				return m_dataTypeForm;
			}
		}

		public ReferenceForm ReferenceForm
		{
			get
			{
				if (m_referenceForm != null && m_referenceForm.Visible)
					return m_referenceForm;

				m_referenceForm = new ReferenceForm();
				m_referenceForm.Show();
				return m_referenceForm;
			}
		}

		public void AllowSetForegroundWindow()
		{
			// call to allow Logos 4 to take the focus
			AllowSetForegroundWindow(-1);
		}

		public void RefreshApplication()
		{
			// call to double-check the application
			if (UpdateApplication())
				UpdatePanel();
		}

		protected override void OnLoad(EventArgs e)
		{
			// select Launch by default
			FeaturesListBox.SelectedIndex = 0;

			// double-check the application periodically
			RefreshApplicationTimer.Tick += delegate { RefreshApplication(); };
			RefreshApplicationTimer.Start();

			base.OnLoad(e);
		}

		private bool UpdateApplication()
		{
			// create the launcher if necessary
			if (m_launcher == null)
				m_launcher = new LogosLauncher();

			// see if the application has changed
			LogosApplication app = m_launcher.Application;
			if (app == m_app)
				return false;

			// detach events from the old app
			if (m_app != null)
			{
				try
				{
					m_app.PanelActivated -= LogosApplication_PanelActivated;
					m_app.PanelClosed -= LogosApplication_PanelClosed;
					m_app.PanelChanged -= LogosApplication_PanelChanged;
					m_app.PanelOpened -= LogosApplication_PanelOpened;
					m_app.Exiting -= LogosApplication_Exiting;
				}
				catch (COMException)
				{
				}
			}

			m_app = app;

			// attach events to the new app
			if (m_app != null)
			{
				RecordEvent(Resources.MainFormAttaching);

				try
				{
					m_app.PanelActivated += LogosApplication_PanelActivated;
					m_app.PanelClosed += LogosApplication_PanelClosed;
					m_app.PanelChanged += LogosApplication_PanelChanged;
					m_app.PanelOpened += LogosApplication_PanelOpened;
					m_app.Exiting += LogosApplication_Exiting;
				}
				catch (COMException)
				{
				}
			}

			return true;
		}

		private void Invoke(Action action)
		{
			// invoke an action on the UI thread (Logos 4 events occur on other threads)
			Invoke(new EventHandler(delegate { action(); }));
		}

		private void RecordEvent(string text)
		{
			// record an event, keeping the last one visible
			EventsListBox.Items.Add(text);
			EventsListBox.SelectedIndex = EventsListBox.Items.Count - 1;
			EventCountLabel.Text = EventsListBox.Items.Count.ToString();
		}

		private void RecordPanelEvent(string text, object panel)
		{
			ILogosPanel logosPanel = (ILogosPanel) panel;
			RecordEvent(text + ": " + (logosPanel == null ? "(null)" : logosPanel.Title));
		}

		private void UpdatePanel()
		{
			if (m_app == null)
			{
				// application isn't running, so show the Launch pane
				ThePanel.Controls.Clear();
				ThePanel.Controls.Add(new LaunchPane { Dock = DockStyle.Fill });
			}
			else
			{
				// application is running, so show the selected pane
				ThePanel.Controls.Clear();
				Type panelType;
				if (s_panelTypes.TryGetValue(FeaturesListBox.Text, out panelType))
				{
					UserControl control = (UserControl) Activator.CreateInstance(panelType);
					control.Dock = DockStyle.Fill;
					ThePanel.Controls.Add(control);
				}
			}
		}

		private void FeaturesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// update the application and the panel when the selected feature changes
			UpdateApplication();
			UpdatePanel();
		}

		private void LogosApplication_PanelActivated(object panel)
		{
			Invoke(
				() => RecordPanelEvent("PanelActivated", panel));
		}

		private void LogosApplication_PanelClosed(object panel)
		{
			Invoke(
				() => RecordPanelEvent("PanelClosed", panel));
		}

		private void LogosApplication_PanelChanged(object panel, object hint)
		{
			Invoke(
				() => RecordPanelEvent("PanelChanged", panel));
		}

		private void LogosApplication_PanelOpened(object panel)
		{
			Invoke(
				() => RecordPanelEvent("PanelOpened", panel));
		}

		private void LogosApplication_Exiting()
		{
			Invoke(
				() => RecordEvent("Exiting"));
		}

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AllowSetForegroundWindow(int dwProcessId);

		static MainForm s_instance;

		static readonly Dictionary<string, Type> s_panelTypes =
			new Dictionary<string, Type>
			{
				{ "Launch", typeof(LaunchPane) },
				{ "Application", typeof(ApplicationPane) },
				{ "Navigate", typeof(NavigatePane) },
				{ "DataTypes", typeof(DataTypesPane) },
			};

		LogosLauncher m_launcher;
		LogosApplication m_app;
		DataTypeForm m_dataTypeForm;
		ReferenceForm m_referenceForm;
	}
}
