using MaisonEauOr.Models;

namespace MaisonEauOr.Extensions;

public static class BreadCrumbs
{
	public static string ToBreadString(this ProductCategory categ)
	{
		return categ switch
		{
			ProductCategory.Cosmetic => "/catalog-cosmetics",
			ProductCategory.Honey => "/catalog-honeys",
			ProductCategory.Mist => "/catalog-mists",
			ProductCategory.Perfume => "/catalog-perfumes",
			ProductCategory.GourmetPerfurme => "/catalog-gourmets",
			ProductCategory.HairProduct => "/catalog-hairproducts",
			ProductCategory.MadeHome => "/catalog-homes",
			ProductCategory.MuscTahara => "/catalog-musks"
		};
	}
}