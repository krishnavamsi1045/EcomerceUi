using EcomerceUi.Enumerations;

namespace EcomerceUi.Models
{
    public class Order
    {
        public long Id { get; set; }
        public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotoalAmount => Items.Sum(i => i.Amount);
        public OrderStatus Status { get; set; } = OrderStatus.placed;
        public Color Color => _orderStatusColorMap[Status];
        private static readonly IReadOnlyDictionary<OrderStatus, Color> _orderStatusColorMap = new Dictionary<OrderStatus, Color>
        {
            [OrderStatus.placed] = Colors.Yellow,
            [OrderStatus.placed] = Colors.Orange,
            [OrderStatus.placed] = Colors.Blue,
            [OrderStatus.placed] = Colors.Red

        };

    }
}
