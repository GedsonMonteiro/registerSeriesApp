using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class repositorySeries : IRepository<Serie>
	{
        private List<Serie> listSerie = new List<Serie>();
		public void update(int id, Serie objeto)
		{
			listSerie[id] = objeto;
		}

		public void delete(int id)
		{
			listSerie[id].delete();
		}

		public void insert(Serie objeto)
		{
			listSerie.Add(objeto);
		}

		public List<Serie> list()
		{
			return listSerie;
		}

		public int nextId()
		{
			return listSerie.Count;
		}

		public Serie returnToId(int id)
		{
			return listSerie[id];
		}
	}
}