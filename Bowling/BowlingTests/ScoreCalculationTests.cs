using Bowling;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingTests
{
	[TestFixture]
	public class ScoreCalculationReferenceTests
	{
		[Test]

		public void CanCalculateNormalScores()
		{
			var game = new Game
			{
				Frames = new List<Frame>
				{
					new Frame{ Throws = new List<int> {0, 0}},
					new Frame{ Throws = new List<int> {1, 0}},
					new Frame{ Throws = new List<int> {0, 9}},
				}
			};

			var frame1Score = 0 + 0;
			var frame2Score = 1 + 0;
			var frame3Score = 0 + 9;

			Assert.That(game.GetScore(), Is.EqualTo(frame1Score + frame2Score + frame3Score));
		}

		//[Test]
		//public void CanCalculateSpares()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> {1, 9 } },
		//			new Frame { Throws = new List<int> {1, 0 } }
		//		}
		//	};

		//	var frame2Score = 1 + 0;
		//	var frame1Score = 1 + 9;

		//	var frame1Bonus = frame2Score;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame1Score + frame1Bonus + frame2Score));
		//}

		//[Test]
		//public void CanCalculateStrikes()
		//{

		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 1, 0 } },
		//			new Frame { Throws = new List<int> { 2, 0 } },
		//		}
		//	};

		//	var frame3Score = 2 + 0;
		//	var frame2Score = 1 + 0;
		//	var frame1Score = 10;
		//	var frame1Bonus = frame2Score + frame3Score;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame1Score + frame1Bonus + frame2Score + frame3Score));
		//}


		//[Test]
		//public void StrikesArentRecursive()
		//{

		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10, 0 } },
		//			new Frame { Throws = new List<int> { 1, 0 } },
		//			new Frame { Throws = new List<int> { 2, 0 } },
		//		}
		//	};

		//	var frame4Score = 2 + 0;
		//	var frame3Score = 1 + 0;
		//	var frame2Score = 10;
		//	var frame1Score = 10;

		//	var frame1Bonus = frame2Score + frame3Score;
		//	var frame2Bonus = frame3Score + frame4Score;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame1Score + frame1Bonus + frame2Score + frame2Bonus + frame3Score + frame4Score ));
		//}


		//[Test]
		//public void FinalFrameCanBeCalculated()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 1, 2 } },
		//		}
		//	};

		//	var frame10Score = 1 + 2;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame10Score));
		//}

		//[Test]
		//public void StrikeInFinalFrameFollowedByTwoZeroThrows()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 10, 0, 0 } }, 
		//		}
		//	};

		//	var frame10Score = 10 + 0 + 0;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame10Score));
		//}

		//[Test]
		//public void StrikeInFinalFrameFollowedByMaximumScoringThrows()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 10, 10, 10 } },
		//		}
		//	};

		//	var frame10Score = 10 + 10 + 10;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame10Score));
		//}

		//[Test]
		//public void SpareInFinalFrameFollowedByZeroThrow()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 9, 1, 0 } },
		//		}
		//	};

		//	var frame10Score = 9 + 1 + 0;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame10Score));
		//}


		//[Test]
		//public void SpareInFinalFrameFollowedByMaximumValueThrow()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 9, 1, 10 } },
		//		}
		//	};

		//	var frame10Score = 9 + 1 + 10;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame10Score));
		//}


		//[Test]
		//public void StrikeBonusInNinthFrame()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 10, 0 } },
		//			new Frame { Throws = new List<int> { 1, 0 } },
		//		}
		//	};

		//	var frame9Score = 10;
		//	var frame9Bonus = 1;
		//	var frame10Score = 1;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame9Score + frame9Bonus + frame10Score));
		//}

		//[Test]
		//public void StrikeBonusInNinthFrameWithBonusInFinalFrame()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 0, 0 } },
		//			new Frame { Throws = new List<int> { 10, 0 } },
		//			new Frame { Throws = new List<int> { 9, 1, 1 } },
		//		}
		//	};

		//	var frame9Score = 10;
		//	var frame9Bonus = 9 + 1;
		//	var frame10Score = 9 + 1;
		//	var frame10BonusBalls = 1;

		//	Assert.That(game.GetScore(), Is.EqualTo(frame9Score + frame9Bonus + frame10Score + frame10BonusBalls));
		//}


		//[Test]
		//public void ThePerfectGame()
		//{
		//	var game = new Game
		//	{
		//		Frames = new List<Frame>
		//		{
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10 } },
		//			new Frame { Throws = new List<int> { 10, 10, 10 } },
		//		}
		//	};

		//	Assert.That(game.GetScore(), Is.EqualTo(300));
		//}
	}
}
