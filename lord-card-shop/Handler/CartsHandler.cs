using lord_card_shop.Model;
using lord_card_shop.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace lord_card_shop.Handler
{
    public class CartsHandler
    {
        public static string AddToCart(int cardId, int userId, int quantity)
        {
            try
            {
                List<Cart> cart = CartsRepository.GetCartsById(userId);
                Cart exist = cart.Find(c => c.CardID == cardId);

                if (exist != null)
                {
                    exist.Quantity++;
                    CartsRepository.UpdateCart(exist);
                }
                else
                {
                    CartsRepository.AddCart(cardId, userId, 1);
                }
                return "Item added successfully.";
            }
            catch
            {
                return "Fail to add new item to cart.";
            }
        }

        public static List<Cart> ViewCart(int id)
        {
            return CartsRepository.GetCartsById(id);
        }

        public static DataTable GetCartDisplayByUserId(int userId)
        {
            return CartsRepository.GetCartDataByUserId(userId);
        }
        /*
        public static string CheckoutCart(int id)
        {
            to be implemented
        }
        */

    }
}