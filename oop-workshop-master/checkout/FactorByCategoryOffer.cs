using System;

namespace oop_workshop_master
{
    public class FactorByCategoryOffer : Offer
    {
        internal readonly Category category;
        internal readonly int factor;
        internal readonly Trademark trademark;
        public FactorByCategoryOffer(Trademark trademark, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.trademark = trademark;
        }
        public FactorByCategoryOffer(Category category, int factor, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.category = category;
            this.factor = factor;
        }
        public override void Apply(Check check)
        {
            int points = check.getCostByCategory(this.category);

            check.AddPoints(points * (this.factor - 1));

            check.AddPoints(check.getCostByTrademark(this.trademark));

        }
    }
}