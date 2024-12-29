﻿namespace AppLidra.Shared.Models
{
    public class ExpenseShare
    {
        public string UserName { get; set; }
        public double Share { get; set; }

        public ExpenseShare(string userName, double share)
        {
            if (share is < 0 or > 1)
            {
                throw new ArgumentException("share out of bounds.");
            }

            UserName = userName;
            Share = share;
        }
    }
}
