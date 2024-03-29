﻿using System;
namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieves one order item.
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves the order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
