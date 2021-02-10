using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_Lottozahlen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnZiehung_Click(object sender, EventArgs e)
		{
			// Zufallszahlengenerator deklarieren
			Random r = new Random();
			int zufallszahl;

			int[] erzeugteZufallszahlen = new int[6];

			// ListBox leeren
			lstLottozahlen.Items.Clear();

			// Zufallszahlen generieren und in Zwischenarray speichern
			for (int i = 0; i < 6; i++)
			{
				do
				{
					zufallszahl = r.Next(1, 49);
				} while (Array.IndexOf(erzeugteZufallszahlen, zufallszahl) != -1);

				erzeugteZufallszahlen[i] = zufallszahl;
			}

			// Array sortieren
			Array.Sort(erzeugteZufallszahlen);

			// Einträge aus dem Array in die ListBox übernehmen
			//for (int i = 0; i < erzeugteZufallszahlen.Length; i++)
			//{
			//	lstLottozahlen.Items.Add(erzeugteZufallszahlen[i]);
			//}
			foreach (int i in erzeugteZufallszahlen) lstLottozahlen.Items.Add(i);

			// Zusatzzahl erstellen und ausgeben
			zufallszahl = r.Next(1, 49);
			txtZusatzzahl.Text = zufallszahl.ToString();
			// Alternativ: txtZusatzzahl.Text = Convert.ToString(zufallszahl);
		}
	}
}
