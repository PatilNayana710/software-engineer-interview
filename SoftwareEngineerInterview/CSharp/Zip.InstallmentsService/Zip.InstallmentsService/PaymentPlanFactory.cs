using System;
using System.Collections.Generic;

namespace Zip.InstallmentsService
{
    /// <summary>
    /// This class is responsible for building the PaymentPlan according to the Zip product definition.
    /// </summary>
    public class PaymentPlanFactory
    {
        /// <summary>
        /// Builds the PaymentPlan instance.
        /// </summary>
        /// <param name="purchaseAmount">The total amount for the purchase that the customer is making.</param>
        /// <returns>The PaymentPlan created with all properties set.</returns>
        public PaymentPlan CreatePaymentPlan(decimal purchaseAmount)
        {
            decimal installmentAmount;
            installmentAmount = purchaseAmount / 4;
            DateTime orderDate = DateTime.Today;
            List<Installment> InstallmentList = new List<Installment>();

            for (int i=1; i<=4; i++)
            {
                

                Installment installment = new Installment();
                installment.DueDate = orderDate.AddDays(14);
                installment.Amount= installmentAmount;
                InstallmentList.Add(new Installment { DueDate = orderDate.AddDays(14), Amount = installmentAmount });
            }

            Installment[]  installaments = InstallmentList.ToArray();
            PaymentPlan paymentPlan = new PaymentPlan();

            paymentPlan.PurchaseAmount = purchaseAmount;
            paymentPlan.Installments = installaments;


            // TODO
            return new PaymentPlan();
        }
    }
}
