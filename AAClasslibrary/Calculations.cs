﻿ using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
namespace BusinessLogic
{ 
	public class Calculations : ICalculationsRepository
	{
		public Review[] Reviews;
		public double CalculateAverage(List<double> ratingList)
		{
			double sum = 0;
			var count = 0;
			foreach (var num in ratingList)
			{
				sum += num;
				count++;

			}
			var average = sum / count;

			var roundedResult = Math.Round(average, 2, MidpointRounding.AwayFromZero);
			var AvgRating = roundedResult;
			return AvgRating;
		}
		public int CalculateUserWeight(int userId, List<Review> re)
		{
			int result = 0;
			foreach (var r in re)
			{
				result = re.Count(r => r.UserId == userId);
			}
			return result;
		}


		public double CalculateAverageWeightDestination(int desId, List<Review> reviews)
		{
			double sum = 0;
			int count = 0;

			var userRatingCount = reviews
				.GroupBy(u => u.UserId)
				.ToDictionary(g => g.Key, g => g.Count());

			var userRatingForThisDes = reviews
				.Where(x => x.DestinationId == desId)
				.GroupBy(u => u.UserId)
				.ToDictionary(g => g.Key, g => g.FirstOrDefault().Rating);

			Dictionary<int, double> totalSumofRatingofUser = new Dictionary<int, double>();

			foreach (KeyValuePair<int, double> entry in userRatingForThisDes)
			{
				if (userRatingCount.ContainsKey(entry.Key))
				{
					sum += entry.Value * userRatingCount[entry.Key];
					count += userRatingCount[entry.Key];
				}
			}

			var avgWeight = sum / count;

			var average = Math.Round(avgWeight, 2, MidpointRounding.AwayFromZero);

			return average;
		}
		
		public Review[] UserWithMostReviewWeight(List<Review> reviews)
		{
			Reviews = reviews.OrderByDescending(u => CalculateUserWeight(u.UserId, reviews)).ToArray();

            return Reviews;
        }
	}
}
