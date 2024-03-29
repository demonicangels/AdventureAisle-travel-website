﻿using BusinessLogic.Interfaces;

namespace BusinessLogic
{
    public class Recommendations : IRecommendationsRepository
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

        public Destination[] RecommendationsByClimateUsers(int userId, DestinationService desService)
        {
            var userDes = desService.AllDesOfUser(userId).ToList();
            var allDestinations = desService.GetAllDestinations();

            if (userDes.Count > 1)
            {
                var duplicates = userDes.GroupBy(c => c.Climate)
                    .Where(d => d.Count() > 1)
                    .ToDictionary(d => d.Key, d => d.Count())
                    .ToList();

                var mostVisitedC = duplicates.OrderByDescending(c => c.Value).FirstOrDefault();

                var recommendations = allDestinations.Where(d => !userDes.Any(des => des.Name == d.Name) && d.Climate == mostVisitedC.Key);
                return recommendations.ToArray();
            }
            else if (userDes.Count == 1)
            {
                var singleDestinationClimate = userDes.Where(d => d.UsrId == userId).FirstOrDefault();
                var recommendations = allDestinations.Where(d => !userDes.Any(des => d.Name == des.Name) && d.Climate == singleDestinationClimate.Climate).ToList();
                return recommendations.ToArray();
            }
            else
            {
                return BestRatedDestinations(desService);
            }
        }

        public Destination[] BestRatedDestinations(DestinationService desService)
        {
            var destinations = desService.GetAllDestinations().ToList();
            List<double> ratings = new List<double>();
            foreach (var d in destinations)
            {
                ratings.Add(d.AvgRating);
            }
            var avgBestRating = CalculateAverage(ratings);

            int countList = destinations.Count;
            List<Destination> bestRateddesti = new List<Destination>();
            for (int i = countList - 1; i >= 0; i--)
            {
                if (destinations[i].AvgRating > avgBestRating)
                {
                    bestRateddesti.Add(destinations[i]);
                }
            }
            bestRateddesti = bestRateddesti.OrderByDescending(d => d.AvgRating).ToList();
            return bestRateddesti.ToArray();
        }

        public Destination[] RecommendationByClimateVisitors(string climate, DestinationService desService)
        {
            var destinations = desService.GetAllDestinations().ToList();

            var desiredClimateDestinations = destinations.Where(d => d.Climate.Contains(climate)).ToList();

            desiredClimateDestinations = desiredClimateDestinations.OrderByDescending(d => d.Name).ToList();
                
            return desiredClimateDestinations.ToArray();
        }
        public Destination[] RecommendationByWantedRating (double wantedRating, DestinationService desService)
        {
            var destinations = desService.GetAllDestinations().ToList();

            var desiredRating = destinations.Where(r => r.AvgRating == wantedRating);

            desiredRating = desiredRating.OrderByDescending(n => n.Name).ToList();

            return desiredRating.ToArray();
        }
    }
}
