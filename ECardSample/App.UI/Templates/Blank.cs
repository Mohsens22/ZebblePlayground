namespace UI.Templates
{
    using System.Threading.Tasks;
    using Zebble;

    class Blank : Page
    {
        public SafeArea SafeAreaContainer = new SafeArea();
        public ScrollView BodyScroller = new ScrollView().Id("BodyScroller");
        public Stack Body;

        protected override async Task InitializeFromMarkup()
        {
            await base.InitializeFromMarkup();

            await Add(SafeAreaContainer);
            await SafeAreaContainer.Add(BodyScroller);
            await BodyScroller.Add(Body = new Stack().Id("Body"));
        }

        public override async Task OnInitializing()
        {
            await SetPseudoCssState("dark", UIContext.IsDark());
            await base.OnInitializing();
            BackgroundColor = Root.BackgroundColor;
        }
    }
}