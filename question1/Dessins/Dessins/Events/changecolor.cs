namespace Dessins.Events
{
    public class changecolor:DrawingEvent
    {
        public override string Type { get { return "changecolor"; } }
        public string Color { get; set; }
        public changecolor(string color)
        {
            Color = color;
        }
    }
}
