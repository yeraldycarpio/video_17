using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace video_17
{
	public class Alumno : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		string nombre = string.Empty;

		public string Nombre
		{
			get => nombre;
			set
			{
				if (nombre == value)
					return;
				nombre = value;
				onPropertyChaged(nameof(Nombre));
				onPropertyChaged(nameof(MostrarNombre));
			}
				}

		public string MostrarNombre =>$"Nombre ingresado:{Nombre}";

		void onPropertyChaged(string nombre)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));

		}
	}
}
