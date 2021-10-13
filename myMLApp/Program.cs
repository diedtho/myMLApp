using System;

namespace MyMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = @"I think our net was cast a bit wider than theirs."
            };

            // Load model and predict output of sample data
            var result = SentimentModel.Predict(sampleData);

            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            string sentiment = result.Prediction == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
        }
    }
}