﻿using System;
using System.Collections.Generic;
using System.Linq;
using PlantsApi.Models;

namespace PlantsApi.Database
{
	public static class PlantsDbInitializer
	{
		public static void Initialize(PlantsContext context)
		{
			//context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
			if (context.Plants.Any()) { return; }

			var plants = GetPlants();
			plants.ForEach(c => context.Plants.Add(c));

			context.SaveChanges();
		}

		private static List<Plant> GetPlants()
		{
			return new List<Plant>
			{
				new Plant
				{
					Name = "Plant",
					Country = "Country",
					Image = null,
					Bloom = "Bloom",
					Color = "Color",
					Size = "Size",
					Soil = "Soil",
					Sunlight = "Sunlight",
					Water = "Water",
					Fertility = "Fertility",
					MaxLightMmol = 10,
					MinLightMmol = 1,
					MaxLightLux = 10,
					MinLightLux = 1,
					MaxTemp = 10,
					MinTemp = 1,
					MaxEnvHumid = 10,
					MinEnvHumid = 1,
					MaxSoilMoist = 10,
					MinSoilMoist = 1,
					MaxSoilEc = 10,
					MaxSoilEx = 10
				}
			};
		}

	}

}
