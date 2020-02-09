﻿using PlantsApi.Models;
using System.Collections.Generic;

namespace PlantsApi.Interfaces
{
	public interface IPlantsStateRepository
	{
		PlantState GetPlantState(int id);
		IEnumerable<PlantState> GetPlantStates();
		PlantState CreatePlantState(PlantState plantState);
		void UpdatePlantState(PlantState plantState);
		void DeletePlantState(int id);

	}
}