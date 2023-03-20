namespace MauiAppTest.DataTemplateDemo
{
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ValidTemplate { get; set; }
        public DataTemplate InvalidTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Person)item).Age >= 19 ? ValidTemplate : InvalidTemplate;
        }
    }
}
