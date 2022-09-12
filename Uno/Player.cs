using System;
namespace Uno
{
	public class Player
	{
		public string Name { get; set; }
        public List<Card> Hand { get; set; }


        public Player()
		{
			Name = "";
			Hand = new List<Card>();
		}

        public bool HasPlayableCard(Card card)
		{
            foreach (Card card2 in Hand)
            {
                if (Card.PlaysOn(card, card2))
                {
                    return true;
                }
            }
            return false;
        }

        public Card GetFirstPlayableCard(Card card)
		{
            foreach (Card card2 in Hand)
            {
                if (Card.PlaysOn(card2, card))
                {
                    return card2;
                }
            }
            return null;
        }

        public Color MostCommonColor()
		{
            int red_count = 0;
            int yellow_count = 0;
            int blue_count = 0;
            int green_count = 0;
            foreach (Card card in Hand)
            {
                if (card.Color == Color.Red)
                {
                    red_count++;
                }
                else if (card.Color == Color.Yellow)
                {
                    yellow_count++;
                }
                else if (card.Color == Color.Blue)
                {
                    blue_count++;
                }
                else if (card.Color == Color.Green)
                {
                    green_count++;
                }
            }
            List<int> count_list = new List<int>();
            count_list.Add(red_count);
            count_list.Add(yellow_count);
            count_list.Add(blue_count);
            count_list.Add(green_count);
            int max_count = count_list.Max();
            if (red_count == max_count)
            {
                return Color.Red;
            }
            else if (yellow_count == max_count)
            {
                return Color.Yellow;
            }
            else if (blue_count == max_count)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Green;
            }
        }


    }
}

