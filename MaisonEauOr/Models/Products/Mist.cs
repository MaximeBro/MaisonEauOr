﻿namespace MaisonEauOr.Models.Products;

public class Mist
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public List<Option> Scents { get; set; }
	public double Price { get; set; }
	public string Description { get; set; }
	public DateTime AddedAt { get; set; }
	public int StockAmount { get; set; } 
	public bool IsAvailable { get; set; }
	public string ImagePath { get; set; }
}