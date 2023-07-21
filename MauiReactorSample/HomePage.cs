using MauiReactor;

namespace MauiReactorSample
{
    public class MainPage : Component
    {
        public override VisualNode Render()
        {
            return new ContentPage
            {
                 new Label("Hi!")
                    .HCenter()
                    .VCenter()
            };
        }
    }
}
