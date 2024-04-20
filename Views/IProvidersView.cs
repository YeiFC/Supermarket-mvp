namespace Supermarket_mvp.Views
{
    internal interface IProvidersView
    {
        string ProviderId { get; set; }
        string ProviderName { get; set; }
        string ProviderContactName { get; set; }
        string ProviderContactPhone { get; set; }
        string ProviderEmail { get; set; }

        string SearchValue { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProviderListBindingSource(BindingSource providerList);
        void Show();
    }
}