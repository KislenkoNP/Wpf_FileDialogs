using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Wpf_FileDialogs {
	public partial class MainWindow : Window {
		public MainWindow () {
			InitializeComponent ();
		}

		private void btnOpenFile_Click (object sender, RoutedEventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.InitialDirectory = @"d:\Prog\";
			if (openFileDialog.ShowDialog () == true)
				txtEditor.Text = File.ReadAllText (openFileDialog.FileName);
		}
		private void btnSaveFile_Click (object sender, RoutedEventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.InitialDirectory = @"d:\Prog\";
			if (saveFileDialog.ShowDialog () == true)
				File.WriteAllText (saveFileDialog.FileName, txtEditor.Text);
 		}
		}
}